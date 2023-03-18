using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace InteractiveCrm
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "InteractiveCrm"),
        ExportMetadata("Description", "Provides a simple interface to interact trough C# with the IOrganizationService without creating a dedicated console application"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class InteractiveCrmPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new InteractiveCrmPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public InteractiveCrmPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }
            else
            {
                // load from the path to this plugin assembly, not host executable
                string dir = AppDomain.CurrentDomain.BaseDirectory;
                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
            }

            return loadAssembly;
        }
    }
}