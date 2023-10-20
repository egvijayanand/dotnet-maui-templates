using Community.VisualStudio.Toolkit;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace VijayAnand.MauiTemplates
{
    public class CustomActionWizard : IWizard
    {
        DTE ide;
        string destinationFolder;

        /// <summary>This method is called before opening any item that has the OpenInEditor attribute.</summary>
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
            //throw new System.NotImplementedException();
        }

        public void ProjectFinishedGenerating(Project project)
        {
            //throw new System.NotImplementedException();
        }

        /// <summary>This method is only called for item templates, not for project templates.</summary>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
            //throw new System.NotImplementedException();
        }

        /// <summary>This method is called after the project is created.</summary>
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
                    if (replacementsDictionary.ContainsKey("$basenamespace$"))
                    {
                        if (replacementsDictionary.TryGetValue("$rootnamespace$", out var rootNamespace))
                        {
                            if (!string.IsNullOrEmpty(rootNamespace))
                            {
                                var match = Regex.Match(rootNamespace, @"\.Platforms\.\w{3,}");

                                if (rootNamespace.EndsWith("Controls", StringComparison.OrdinalIgnoreCase)
                                    || rootNamespace.EndsWith("Handlers", StringComparison.OrdinalIgnoreCase))
                                {
                                    replacementsDictionary["$basenamespace$"] = rootNamespace.Substring(0, rootNamespace.LastIndexOf('.'));
                                }
                                else if (match.Success)
                                {
                                    replacementsDictionary["$basenamespace$"] = rootNamespace.Substring(0, match.Index);
                                }
                                else
                                {
                                    replacementsDictionary["$basenamespace$"] = rootNamespace;
                                }
                            }
                        }
                    }

                    if (replacementsDictionary.ContainsKey("$net8$"))
                    {
                        var project = await VS.Solution.GetActiveProjectAsync();

                        string tfm;

                        if (project != null)
                        {
                            tfm = await project.GetAttributeAsync("TargetFrameworks");

                            if (tfm != null)
                            {
                                if (tfm.Contains("net8.0"))
                                {
                                    replacementsDictionary["$net8$"] = "true";
                                }
                            }
                            else
                            {
                                tfm = await project.GetAttributeAsync("TargetFramework");

                                if (tfm != null)
                                {
                                    if (tfm.StartsWith("net8.0"))
                                    {
                                        replacementsDictionary["$net8$"] = "true";
                                    }
                                }
                            }
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

        /// <summary>This method is only called for item templates, not for project templates.</summary>
        public bool ShouldAddProjectItem(string filePath)
        {
            //throw new System.NotImplementedException();
            return true;
        }
    }
}
