﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SuiteCRMAddIn.BusinessLogic;

namespace SuiteCRMAddIn.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<System.String> AutoArchiveFolders {
            get {
                return ((global::System.Collections.Generic.List<System.String>)(this["AutoArchiveFolders"]));
            }
            set {
                this["AutoArchiveFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<System.String> AccountsToArchiveInbound {
            get {
                return ((global::System.Collections.Generic.List<System.String>)(this["AccountsToArchiveInbound"]));
            }
            set {
                this["AccountsToArchiveInbound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<System.String> AccountsToArchiveOutbound {
            get {
                return ((global::System.Collections.Generic.List<System.String>)(this["AccountsToArchiveOutbound"]));
            }
            set {
                this["AccountsToArchiveOutbound"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<System.String> CustomModules {
            get {
                return ((global::System.Collections.Generic.List<System.String>)(this["CustomModules"]));
            }
            set {
                this["CustomModules"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ExcludedEmails {
            get {
                return ((string)(this["ExcludedEmails"]));
            }
            set {
                this["ExcludedEmails"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("b8794235718652747b82fd713deac078")]
        public string PublicKey {
            get {
                return ((string)(this["PublicKey"]));
            }
            set {
                this["PublicKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Username {
            get {
                return ((string)(this["Username"]));
            }
            set {
                this["Username"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Password {
            get {
                return ((string)(this["Password"]));
            }
            set {
                this["Password"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Host {
            get {
                return ((string)(this["Host"]));
            }
            set {
                this["Host"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ArchiveAttachments {
            get {
                return ((bool)(this["ArchiveAttachments"]));
            }
            set {
                this["ArchiveAttachments"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutomaticSearch {
            get {
                return ((bool)(this["AutomaticSearch"]));
            }
            set {
                this["AutomaticSearch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::SuiteCRMAddIn.BusinessLogic.EmailCategoriesCollection EmailCategories {
            get {
                return ((global::SuiteCRMAddIn.BusinessLogic.EmailCategoriesCollection)(this["EmailCategories"]));
            }
            set {
                this["EmailCategories"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowCustomModules {
            get {
                return ((bool)(this["ShowCustomModules"]));
            }
            set {
                this["ShowCustomModules"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000")]
        public int SyncMaxRecords {
            get {
                return ((int)(this["SyncMaxRecords"]));
            }
            set {
                this["SyncMaxRecords"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"1,2,3\"")]
        public string SelectedSearchModules {
            get {
                return ((string)(this["SelectedSearchModules"]));
            }
            set {
                this["SelectedSearchModules"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool PopulateContextLookupList {
            get {
                return ((bool)(this["PopulateContextLookupList"]));
            }
            set {
                this["PopulateContextLookupList"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoArchive {
            get {
                return ((bool)(this["AutoArchive"]));
            }
            set {
                this["AutoArchive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction SyncContacts {
            get {
                return ((global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction)(this["SyncContacts"]));
            }
            set {
                this["SyncContacts"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsLDAPAuthentication {
            get {
                return ((bool)(this["IsLDAPAuthentication"]));
            }
            set {
                this["IsLDAPAuthentication"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LDAPKey {
            get {
                return ((string)(this["LDAPKey"]));
            }
            set {
                this["LDAPKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowConfirmationMessageArchive {
            get {
                return ((bool)(this["ShowConfirmationMessageArchive"]));
            }
            set {
                this["ShowConfirmationMessageArchive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Error")]
        public global::SuiteCRMClient.Logging.LogEntryType LogLevel {
            get {
                return ((global::SuiteCRMClient.Logging.LogEntryType)(this["LogLevel"]));
            }
            set {
                this["LogLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int DaysOldEmailToAutoArchive {
            get {
                return ((int)(this["DaysOldEmailToAutoArchive"]));
            }
            set {
                this["DaysOldEmailToAutoArchive"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LicenceKey {
            get {
                return ((string)(this["LicenceKey"]));
            }
            set {
                this["LicenceKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("300000")]
        public int RestTimeout {
            get {
                return ((int)(this["RestTimeout"]));
            }
            set {
                this["RestTimeout"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NeedsUpgrade {
            get {
                return ((bool)(this["NeedsUpgrade"]));
            }
            set {
                this["NeedsUpgrade"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction SyncCalls {
            get {
                return ((global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction)(this["SyncCalls"]));
            }
            set {
                this["SyncCalls"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction SyncMeetings {
            get {
                return ((global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction)(this["SyncMeetings"]));
            }
            set {
                this["SyncMeetings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction SyncTasks {
            get {
                return ((global::SuiteCRMAddIn.BusinessLogic.SyncDirection.Direction)(this["SyncTasks"]));
            }
            set {
                this["SyncTasks"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{ \"Contacts\": [ { \"linkName\": \"accounts_contacts_1\", \"targetName\": \"accounts\", \"f" +
            "ields\": [\"id\", \"name\" ]}]}")]
        public string ArchivingSearchChains {
            get {
                return ((string)(this["ArchivingSearchChains"]));
            }
            set {
                this["ArchivingSearchChains"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FirstTime")]
        public ErrorHandler.PopupWhen ShowExceptions {
            get {
                return ((ErrorHandler.PopupWhen)(this["ShowExceptions"]));
            }
            set {
                this["ShowExceptions"] = value;
            }
        }
    }
}
