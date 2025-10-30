using System;
using System.ComponentModel;

namespace UV7_Edit
{
    public class CustomAttributes
    {
        [AttributeUsage(AttributeTargets.Property)]
        public class LocalizedDisplayNameAttribute : DisplayNameAttribute
        {
            public string ResourceKey { get; }
            public LocalizedDisplayNameAttribute(string resourceKey)
            {
                ResourceKey = resourceKey;
            }
            public override string DisplayName =>
                Resources.Prefs.Names.ResourceManager.GetString(ResourceKey)
                ?? ResourceKey;
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class LocalizedDescriptionAttribute : DescriptionAttribute
        {
            public string ResourceKey { get; }
            public LocalizedDescriptionAttribute(string resourceKey)
            {
                ResourceKey = resourceKey;
            }
            public override string Description =>
                Resources.Prefs.Descriptions.ResourceManager.GetString(ResourceKey)
                ?? ResourceKey;
        }

        [AttributeUsage(AttributeTargets.Class)]
        public class LocalizedCategoryAttribute : CategoryAttribute
        {
            public LocalizedCategoryAttribute(string resourceKey) : base(resourceKey) { }

            protected override string GetLocalizedString(string value)
            {
                return Resources.Prefs.Categories.ResourceManager.GetString(value) ?? value;
            }
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
        public class LabelAttribute : Attribute
        {
            public virtual string Label { get; }
            public LabelAttribute(string label = "")
            {
                Label = label;
            }
        }
        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
        public class LocalizedLabelAttribute : LabelAttribute
        {
            public string ResourceKey { get; }
            public LocalizedLabelAttribute(string resourceKey)
            {
                ResourceKey = resourceKey;
            }
            public override string Label =>
                Resources.Prefs.Labels.ResourceManager.GetString(ResourceKey)
                ?? ResourceKey;
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class SettingVisibleAttribute : Attribute
        {
            public bool Visible { get; }
            public SettingVisibleAttribute(bool visible = true)
            {
                Visible = visible;
            }
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class SettingsReadOnlyAttribute : Attribute
        {
            public bool ReadOnly { get; }
            public SettingsReadOnlyAttribute(bool readOnly = true)
            {
                ReadOnly = readOnly;
            }
        }
    }
}
