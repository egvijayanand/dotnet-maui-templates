using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
//using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using VijayAnand.MauiTemplates.Extensions;
using VijayAnand.MauiTemplates.ViewModels;
using VijayAnand.MauiTemplates.Views;

namespace VijayAnand.MauiTemplates
{
    public class CustomActionWizard : IWizard
    {
        const string Colon = ":";
        // Predefined replacement parameter
        const string RootNamespace = "$rootnamespace$";
        // Custom replacement parameters
        const string BaseNamespace = "$base_namespace$";
        const string BaseType = "$base_type$";
        const string BaseTypeCS = "$base_type_cs$";
        const string Generic = "$generic$";
        const string MauiGlobal = "$maui_global$";
        const string MauiImplicit = "$maui_implicit$";
        const string Net8OrLater = "$net8_or_later$";
        const string Net10OrLater = "$net10_or_later$";
        const string Suffix = "$suffix$";
        const string Toolkit = "$toolkit$";
        const string TypeArgs = "$type_args$";
        const string XamlItem = "$xaml_item$";
        const string XamlOnly = "$xaml_only$";

        DTE ide;
        bool xamlOnly;
        bool userCancel;
        bool postProcess;
        string destinationFolder;

        /// <summary>This method is called before opening any item that has the OpenInEditor attribute.</summary>
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            //throw new System.NotImplementedException();
        }

        /// <summary>
        /// Called when the project has finished being generated.
        /// </summary>
        /// <param name="project">The Project object of the project that was generated.</param>
        public void ProjectFinishedGenerating(Project project)
        {
            //throw new System.NotImplementedException();
        }

        /// <summary>This method is only called for item templates, not for project templates.</summary>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            if (postProcess)
            {
                if (projectItem.Name.EndsWith(".xaml"))
                {
                    // Get the full path of the XAML file
                    string xamlFilePath = projectItem.FileNames[1];

                    // Read all lines, remove blank ones, and write back
                    var lines = File.ReadAllLines(xamlFilePath);
                    var contentLines = new List<string>(lines.Length);

                    foreach (var line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            contentLines.Add(line);
                        }
                    }

                    //contentLines.Add(string.Empty); // Ensure the file ends with a newline
                    File.WriteAllLines(xamlFilePath, contentLines);
                    contentLines.Clear();
                }
            }
        }

        /// <summary>
        /// This method is called after the project is created.
        /// </summary>
        public void RunFinished()
        {
            ThreadHelper.ThrowIfNotOnUIThread();

            if (!string.IsNullOrEmpty(destinationFolder))
            {
                var mauiProjectPath = Path.GetDirectoryName(ide.Solution.Projects.Item(1).FullName);

                var sourceFilePath = Path.Combine(mauiProjectPath, "Directory.Build.targets");
                var destFilePath = Path.Combine(destinationFolder, "Directory.Build.targets");

                if (File.Exists(sourceFilePath))
                {
                    File.Move(sourceFilePath, destFilePath);
                }
            }
        }

        public async void RunStarted(object automationObject,
                                     Dictionary<string, string> replacementsDictionary,
                                     WizardRunKind runKind,
                                     object[] customParams)
        {
            try
            {
                //ThreadHelper.ThrowIfNotOnUIThread();
                await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
                ide = automationObject as DTE;
                replacementsDictionary.TryGetValue("$destinationdirectory$", out destinationFolder);

                if (replacementsDictionary.ContainsKey("$MauiAppId$"))
                {
                    replacementsDictionary["$MauiAppId$"] = replacementsDictionary["$safeprojectname$"].ToLowerInvariant();
                }

                if (runKind == WizardRunKind.AsNewItem)
                {
                    // XAML-based item template. Needs post processing.
                    postProcess = replacementsDictionary.ContainsKey(XamlItem);
                    var net8OrLater = false;
                    var net10OrLater = false;

                    // Multi-Folder templates.
                    if (replacementsDictionary.ContainsKey(BaseNamespace))
                    {
                        if (replacementsDictionary.TryGetValue(RootNamespace, out var rootNamespace))
                        {
                            if (!string.IsNullOrEmpty(rootNamespace))
                            {
                                var match = Regex.Match(rootNamespace, @"\.Platforms\.\w{3,}");

                                if (rootNamespace.EndsWith("Controls", StringComparison.OrdinalIgnoreCase)
                                    || rootNamespace.EndsWith("Handlers", StringComparison.OrdinalIgnoreCase))
                                {
                                    replacementsDictionary[BaseNamespace] = rootNamespace.Substring(0, rootNamespace.LastIndexOf('.'));
                                }
                                else if (match.Success)
                                {
                                    replacementsDictionary[BaseNamespace] = rootNamespace.Substring(0, match.Index);
                                }
                                else
                                {
                                    replacementsDictionary[BaseNamespace] = rootNamespace;
                                }
                            }
                        }
                    }

                    var project = await VS.Solution.GetActiveProjectAsync();

                    string tfm;

                    if (project != null)
                    {
                        tfm = await project.GetAttributeAsync("TargetFrameworks");

                        if (tfm.HasValue())
                        {
                            if (tfm.Contains("net8.0")
                                || tfm.Contains("net9.0")
                                || tfm.Contains("net10.0"))
                            {
                                net8OrLater = true;

                                if (tfm.Contains("net10.0"))
                                {
                                    net10OrLater = true;
                                }
                            }
                        }
                        else
                        {
                            tfm = await project.GetAttributeAsync("TargetFramework");

                            if (tfm != null)
                            {
                                if (tfm.StartsWith("net8.0")
                                    || tfm.StartsWith("net9.0")
                                    || tfm.StartsWith("net10.0"))
                                {
                                    net8OrLater = true;

                                    if (tfm.StartsWith("net10.0"))
                                    {
                                        net10OrLater = true;
                                    }
                                }
                            }
                        }
                    }

                    // Version based customization.
                    if (replacementsDictionary.ContainsKey(Net8OrLater))
                    {
                        replacementsDictionary[Net8OrLater] = net8OrLater.ToString().ToLowerInvariant();
                    }

                    if (replacementsDictionary.ContainsKey(Net10OrLater))
                    {
                        replacementsDictionary[Net10OrLater] = net10OrLater.ToString().ToLowerInvariant();
                    }

                    if (replacementsDictionary.ContainsKey(MauiGlobal))
                    {
                        replacementsDictionary[MauiGlobal] = net10OrLater.ToString().ToLowerInvariant();
                    }

                    // Generic item template.
                    if (replacementsDictionary.ContainsKey(BaseType))
                    {
                        var ideVersion = 17; // VS2022, supported base IDE version.
                        var xamlItem = replacementsDictionary.ContainsKey(XamlItem);

                        if (Version.TryParse(ide.Version, out var version))
                        {
                            ideVersion = version.Major;
                        }

                        var viewModel = new GenericItemViewModel(xamlItem, net10OrLater, ideVersion);
                        var result = new GenericItemDialog(viewModel).ShowDialog();

                        if (result is true)
                        {
                            xamlOnly = viewModel.XamlOnly;
                            var globalNamespace = viewModel.GlobalNamespace;
                            var implicitNamespace = viewModel.ImplicitNamespace;
                            replacementsDictionary[Suffix] = viewModel.ItemSuffix;
                            replacementsDictionary[XamlOnly] = xamlOnly.ToString().ToLowerInvariant();

                            var baseType = viewModel.BaseTypeName;
                            var genericType = viewModel.GenericTypeName;
                            var baseTypeCS = baseType.Contains(Colon) ? baseType.Substring(baseType.IndexOf(':') + 1) : baseType;
                            var genericTypeCS = genericType.Contains(Colon) ? genericType.Substring(genericType.IndexOf(':') + 1) : genericType;

                            if (!string.IsNullOrEmpty(baseType))
                            {
                                if (postProcess)
                                {
                                    string toolkit;

                                    if (baseType.Contains(Colon) && string.Equals(baseType.Substring(0, baseType.IndexOf(':')), "mct", StringComparison.OrdinalIgnoreCase))
                                    {
                                        toolkit = bool.TrueString.ToLowerInvariant();
                                    }
                                    else
                                    {
                                        toolkit = bool.FalseString.ToLowerInvariant();
                                    }

                                    replacementsDictionary[BaseType] = (globalNamespace || implicitNamespace) ? baseTypeCS : baseType;
                                    replacementsDictionary[MauiGlobal] = globalNamespace.ToString().ToLowerInvariant();
                                    replacementsDictionary[MauiImplicit] = implicitNamespace.ToString().ToLowerInvariant();
                                    replacementsDictionary[Toolkit] = toolkit;

                                    if (string.IsNullOrEmpty(genericTypeCS))
                                    {
                                        replacementsDictionary[BaseTypeCS] = baseTypeCS;
                                        replacementsDictionary[Generic] = bool.FalseString.ToLowerInvariant();
                                    }
                                    else
                                    {
                                        replacementsDictionary[BaseTypeCS] = $"{baseTypeCS}<{genericTypeCS}>";
                                        replacementsDictionary[Generic] = bool.TrueString.ToLowerInvariant();
                                        replacementsDictionary[TypeArgs] = (globalNamespace || implicitNamespace) ? genericTypeCS : genericType;
                                    }
                                }
                                else
                                {
                                    // For C# template also, base_type is the parameter name.
                                    if (string.IsNullOrEmpty(genericTypeCS))
                                    {
                                        replacementsDictionary[BaseType] = baseTypeCS;
                                    }
                                    else
                                    {
                                        replacementsDictionary[BaseType] = $"{baseTypeCS}<{genericTypeCS}>";
                                    }
                                }
                            }
                        }
                        else
                        {
                            userCancel = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception.
                await ex.LogAsync();
            }
        }

        /*public void RunStarted(object automationObject,
                               Dictionary<string, string> replacementsDictionary,
                               WizardRunKind runKind,
                               object[] customParams,
                               IVsProject project,
                               uint parentItemId)
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            ide = automationObject as DTE;
            replacementsDictionary.TryGetValue("$destinationdirectory$", out destinationFolder);
        }*/

        /// <summary>This method is only called for item templates, not for project templates.</summary>
        public bool ShouldAddProjectItem(string filePath)
        {
            if (userCancel)
            {
                return false;
            }
            else if (filePath.EndsWith(".xaml.cs"))
            {
                return !xamlOnly;
            }
            else
            {
                return !File.Exists(filePath);
            }
        }
    }
}
