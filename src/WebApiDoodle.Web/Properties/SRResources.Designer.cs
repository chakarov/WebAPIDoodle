﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiDoodle.Web {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SRResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebApiDoodle.Web.Properties.SRResources", typeof(SRResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} on type {1}.
        /// </summary>
        internal static string ActionSelector_AmbiguousMatchType {
            get {
                return ResourceManager.GetString("ActionSelector_AmbiguousMatchType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No action was found on the controller &apos;{0}&apos; that matches the name &apos;{1}&apos;..
        /// </summary>
        internal static string ApiControllerActionSelector_ActionNameNotFound {
            get {
                return ResourceManager.GetString("ApiControllerActionSelector_ActionNameNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No action was found on the controller &apos;{0}&apos; that matches the request..
        /// </summary>
        internal static string ApiControllerActionSelector_ActionNotFound {
            get {
                return ResourceManager.GetString("ApiControllerActionSelector_ActionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple actions were found that match the request: {0}.
        /// </summary>
        internal static string ApiControllerActionSelector_AmbiguousMatch {
            get {
                return ResourceManager.GetString("ApiControllerActionSelector_AmbiguousMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested resource does not support http method &apos;{0}&apos;..
        /// </summary>
        internal static string ApiControllerActionSelector_HttpMethodNotSupported {
            get {
                return ResourceManager.GetString("ApiControllerActionSelector_HttpMethodNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No HTTP resource was found that matches the request URI &apos;{0}&apos;..
        /// </summary>
        internal static string ResourceNotFound {
            get {
                return ResourceManager.GetString("ResourceNotFound", resourceCulture);
            }
        }
    }
}
