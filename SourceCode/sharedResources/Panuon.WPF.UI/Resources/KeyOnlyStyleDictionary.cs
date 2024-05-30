﻿using System;

namespace Panuon.WPF.UI.Resources
{
    public class KeyOnlyStyleDictionary
        : StyleDictionaryBase
    {
        protected override void SetIncludeStyles()
        {
            MergedDictionaries.Clear();
            MergedDictionaries.Add(DefaultResourceDictionary);

            foreach (var flag in Flags)
            {
                if (Includes.HasFlag(StyleDictionaryFlags.All) 
                    || Includes.HasFlag(flag))
                {
                    AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/{flag}Style.xaml") });

                    switch (flag)
                    {
                        case StyleDictionaryFlags.ComboBox:
                        case StyleDictionaryFlags.ListBox:
                        case StyleDictionaryFlags.ListView:
                        case StyleDictionaryFlags.TreeView:
                        case StyleDictionaryFlags.Menu:
                            AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/{flag}ItemStyle.xaml") });
                            break;
                        case StyleDictionaryFlags.TabControl:
                            AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/TabItemStyle.xaml") });
                            break;
                        case StyleDictionaryFlags.ContextMenu:
                            var contextMenuItemDic = new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/MenuItemStyle.xaml") };
                            AddToMergedDictionaries(contextMenuItemDic);
                            break;
                    }
                }
            }
        }

        protected override void SetExcludeStyles()
        {
            MergedDictionaries.Clear();
            MergedDictionaries.Add(DefaultResourceDictionary);

            foreach (var flag in Flags)
            {
                if (!Excludes.HasFlag(StyleDictionaryFlags.All)
                   && !Excludes.HasFlag(flag))
                {
                    AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/{flag}Style.xaml") });

                    switch (flag)
                    {
                        case StyleDictionaryFlags.ComboBox:
                        case StyleDictionaryFlags.ListBox:
                        case StyleDictionaryFlags.ListView:
                        case StyleDictionaryFlags.TreeView:
                        case StyleDictionaryFlags.Menu:
                            AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/{flag}ItemStyle.xaml") });
                            break;
                        case StyleDictionaryFlags.TabControl:
                            AddToMergedDictionaries(new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/TabItemStyle.xaml") });
                            break;
                        case StyleDictionaryFlags.ContextMenu:
                            var contextMenuItemDic = new SharedResourceDictionary() { Source = new Uri($"pack://application:,,,/Panuon.WPF.UI;component/Styles/MenuItemStyle.xaml") };
                            AddToMergedDictionaries(contextMenuItemDic);
                            break;
                    }
                }
            }
        }
    }
}