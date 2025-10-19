using System;
using System.ComponentModel;

namespace UV7_Edit
{
    public class LocalizedAttributes
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
                Properties.Resources.ResourceManager.GetString(ResourceKey)
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
                Properties.Resources.ResourceManager.GetString(ResourceKey)
                ?? ResourceKey;
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class LocalizedCategoryAttribute : CategoryAttribute
        {
            public LocalizedCategoryAttribute(string resourceKey) : base(resourceKey) { }

            protected override string GetLocalizedString(string value)
            {
                return Properties.Resources.ResourceManager.GetString(value) ?? value;
            }
        }

        [AttributeUsage(AttributeTargets.Property)]
        public class SettingsVisibleAttribute : Attribute
        {
            public bool Visible { get; }
            public SettingsVisibleAttribute(bool visible = true)
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
