﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocratexGraphExplorer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("neo4j")]
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
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int QueryFontSize {
            get {
                return ((int)(this["QueryFontSize"]));
            }
            set {
                this["QueryFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas")]
        public string QueryFont {
            get {
                return ((string)(this["QueryFont"]));
            }
            set {
                this["QueryFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("7687")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("localhost")]
        public string Server {
            get {
                return ((string)(this["Server"]));
            }
            set {
                this["Server"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Socratex Graph Explorer")]
        public string AppTitle {
            get {
                return ((string)(this["AppTitle"]));
            }
            set {
                this["AppTitle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ConnectResultNodes {
            get {
                return ((bool)(this["ConnectResultNodes"]));
            }
            set {
                this["ConnectResultNodes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int SourceFontSize {
            get {
                return ((int)(this["SourceFontSize"]));
            }
            set {
                this["SourceFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas")]
        public string SourceFont {
            get {
                return ((string)(this["SourceFont"]));
            }
            set {
                this["SourceFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int TextResultsFontSize {
            get {
                return ((int)(this["TextResultsFontSize"]));
            }
            set {
                this["TextResultsFontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowLineNumbers {
            get {
                return ((bool)(this["ShowLineNumbers"]));
            }
            set {
                this["ShowLineNumbers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{\r\n    \"createGraphNode\": (node) => {\r\n        if (node.labels[0] == \'Class\') {\r\n" +
            "            return { id: node.id, value: node.properties.WMC, label: node.proper" +
            "ties.Name, title: node.properties.$indegree, color: \"red\" }\r\n        }\r\n        " +
            "else if (node.labels[0] == \'Method\') {\r\n            return { id: node.id, value:" +
            " node.properties.LOC, label: node.properties.Name, title: node.properties.$indeg" +
            "ree, color: \"green\", static: node.properties.IsStatic }\r\n        }\r\n        else" +
            " {\r\n\r\n        }\r\n        return { id: node.id, label: node.properties.Name };\r\n " +
            "   },\r\n\r\n    \"createGraphEdge\": (edge) => {\r\n        if (edge.type == \'CALLS\') {" +
            "\r\n            return { id: edge.id, from: edge.from, to: edge.to, value: edge.pr" +
            "operties.Count, label: edge.type, title: \'Calls: \' + edge.properties.Count, colo" +
            "r: {color: \"yellow\" }};\r\n        }\r\n        else {\r\n            return { id: edg" +
            "e.id, from: edge.from, to: edge.to, label: edge.type };\r\n        }\r\n    },\r\n\r\n  " +
            "  \"options\":  {\r\n        interaction: { hover: true, selectConnectedEdges: false" +
            " },\r\n        manipulation: {\r\n            enabled: false, // true enables adding" +
            " nodes to the graph\r\n        },\r\n        nodes: {\r\n            size: 10, // For " +
            "nodes that do not have specific size\r\n            font: { strokeWidth: 2 }, // T" +
            "his is the amount of space around the text in nodes or edges.\r\n            shape" +
            ": \'dot\',\r\n            scaling: {\r\n                label: { // Make sure font siz" +
            "e is in this range.\r\n                    min: 8, max: 40\r\n                }\r\n   " +
            "         }\r\n        },\r\n        edges: {\r\n            arrows: \"to\",\r\n           " +
            " shadow: true,\r\n            smooth: true,\r\n        }\r\n    }\r\n}")]
        public string Configuration {
            get {
                return ((string)(this["Configuration"]));
            }
            set {
                this["Configuration"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DarkMode {
            get {
                return ((bool)(this["DarkMode"]));
            }
            set {
                this["DarkMode"] = value;
            }
        }
    }
}
