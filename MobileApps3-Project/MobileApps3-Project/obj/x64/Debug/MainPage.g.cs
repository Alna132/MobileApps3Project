﻿#pragma checksum "E:\College\Year 4\Mobile App Dev 3\MobileApps3Project\MobileApps3-Project\MobileApps3-Project\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "812690AF7F5517C8B63FF2BD1CE939DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MobileApps3_Project
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class MainPage_obj9_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::MobileApps3_Project.ViewModels.LevelViewModel dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;

            private MainPage_obj9_BindingsTracking bindingsTracking;

            public MainPage_obj9_Bindings()
            {
                this.bindingsTracking = new MainPage_obj9_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9:
                        this.obj9 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.TextBlock)target);
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::MobileApps3_Project.ViewModels.LevelViewModel data = args.NewValue as global::MobileApps3_Project.ViewModels.LevelViewModel;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::MobileApps3_Project.ViewModels.LevelViewModel was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::MobileApps3_Project.ViewModels.LevelViewModel);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.TextBlock)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::MobileApps3_Project.ViewModels.LevelViewModel) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj9_Bindings

            public void SetDataRoot(global::MobileApps3_Project.ViewModels.LevelViewModel newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MobileApps3_Project.ViewModels.LevelViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_level(obj.level, phase);
                    }
                }
            }
            private void Update_level(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9.Target as global::Windows.UI.Xaml.Controls.TextBlock, obj, null);
                }
            }

            private class MainPage_obj9_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj9_Bindings> WeakRefToBindingObj; 

                public MainPage_obj9_BindingsTracking(MainPage_obj9_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj9_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj9_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::MobileApps3_Project.ViewModels.LevelViewModel obj = sender as global::MobileApps3_Project.ViewModels.LevelViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_level(obj.level, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "level":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_level(obj.level, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::MobileApps3_Project.ViewModels.LevelViewModel obj)
                {
                    MainPage_obj9_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
            }
        }

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::MobileApps3_Project.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.StackPanel obj3;
            private global::Windows.UI.Xaml.Controls.TextBox obj4;
            private global::Windows.UI.Xaml.Controls.TextBox obj5;
            private global::Windows.UI.Xaml.Controls.TextBox obj6;
            private global::Windows.UI.Xaml.Controls.Image obj7;
            private global::Windows.UI.Xaml.Controls.ListView obj8;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 7:
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 8:
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        (this.obj8).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.ViewLevels.SelectedIndex = (this.obj8).SelectedIndex;
                                }
                            });
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::MobileApps3_Project.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::MobileApps3_Project.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewLevels(obj.ViewLevels, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels(phase);
                    }
                }
            }
            private void Update_ViewLevels(global::MobileApps3_Project.ViewModels.DifficultyViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewLevels(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewLevels_SelectedLevel(obj.SelectedLevel, phase);
                        this.Update_ViewLevels_Level(obj.Level, phase);
                        this.Update_ViewLevels_SelectedIndex(obj.SelectedIndex, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels_SelectedLevel(phase);
                    }
                }
            }
            private void Update_ViewLevels_SelectedLevel(global::MobileApps3_Project.ViewModels.LevelViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewLevels_SelectedLevel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewLevels_SelectedLevel_level(obj.level, phase);
                        this.Update_ViewLevels_SelectedLevel_items(obj.items, phase);
                        this.Update_ViewLevels_SelectedLevel_description(obj.description, phase);
                        this.Update_ViewLevels_SelectedLevel_image(obj.image, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels_SelectedLevel_level(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels_SelectedLevel_items(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels_SelectedLevel_description(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_ViewLevels_SelectedLevel_image(phase);
                    }
                }
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("ObjectExistsToVisible").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }
            private void Update_ViewLevels_SelectedLevel_level(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj4, obj, null);
                }
            }
            private void Update_ViewLevels_SelectedLevel_items(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, obj.ToString(), null);
                }
            }
            private void Update_ViewLevels_SelectedLevel_description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj6, obj, null);
                }
            }
            private void Update_ViewLevels_SelectedLevel_image(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj7, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                }
            }
            private void Update_ViewLevels_Level(global::System.Collections.ObjectModel.ObservableCollection<global::MobileApps3_Project.ViewModels.LevelViewModel> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }
            private void Update_ViewLevels_SelectedIndex(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj8, obj);
                }
            }

            private void UpdateFallback_ViewLevels(int phase)
            {
                this.UpdateFallback_ViewLevels_SelectedLevel(phase);
            }

            private void UpdateFallback_ViewLevels_SelectedLevel(int phase)
            {
                this.UpdateFallback_ViewLevels_SelectedLevel_level(phase);
                this.UpdateFallback_ViewLevels_SelectedLevel_items(phase);
                this.UpdateFallback_ViewLevels_SelectedLevel_description(phase);
                this.UpdateFallback_ViewLevels_SelectedLevel_image(phase);
            }

            private void UpdateFallback_ViewLevels_SelectedLevel_level(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj4, "", null);
                }
            }

            private void UpdateFallback_ViewLevels_SelectedLevel_items(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj5, " ", null);
                }
            }

            private void UpdateFallback_ViewLevels_SelectedLevel_description(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj6, " ", null);
                }
            }

            private void UpdateFallback_ViewLevels_SelectedLevel_image(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj7, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), "0"), null);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewLevels(null);
                    UpdateChildListeners_ViewLevels_SelectedLevel(null);
                }

                public void PropertyChanged_ViewLevels(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::MobileApps3_Project.ViewModels.DifficultyViewModel obj = sender as global::MobileApps3_Project.ViewModels.DifficultyViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewLevels_SelectedLevel(obj.SelectedLevel, DATA_CHANGED);
                                    bindings.Update_ViewLevels_Level(obj.Level, DATA_CHANGED);
                                    bindings.Update_ViewLevels_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_ViewLevels_SelectedLevel(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedLevel":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedLevel(obj.SelectedLevel, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewLevels_SelectedLevel(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Level":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_Level(obj.Level, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedIndex":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedIndex(obj.SelectedIndex, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::MobileApps3_Project.ViewModels.DifficultyViewModel cache_ViewLevels = null;
                public void UpdateChildListeners_ViewLevels(global::MobileApps3_Project.ViewModels.DifficultyViewModel obj)
                {
                    if (obj != cache_ViewLevels)
                    {
                        if (cache_ViewLevels != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewLevels).PropertyChanged -= PropertyChanged_ViewLevels;
                            cache_ViewLevels = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewLevels = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewLevels;
                        }
                    }
                }
                public void PropertyChanged_ViewLevels_SelectedLevel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::MobileApps3_Project.ViewModels.LevelViewModel obj = sender as global::MobileApps3_Project.ViewModels.LevelViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_ViewLevels_SelectedLevel_level(obj.level, DATA_CHANGED);
                                    bindings.Update_ViewLevels_SelectedLevel_items(obj.items, DATA_CHANGED);
                                    bindings.Update_ViewLevels_SelectedLevel_description(obj.description, DATA_CHANGED);
                                    bindings.Update_ViewLevels_SelectedLevel_image(obj.image, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_ViewLevels_SelectedLevel_level(DATA_CHANGED);
                                bindings.UpdateFallback_ViewLevels_SelectedLevel_items(DATA_CHANGED);
                                bindings.UpdateFallback_ViewLevels_SelectedLevel_description(DATA_CHANGED);
                                bindings.UpdateFallback_ViewLevels_SelectedLevel_image(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "level":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedLevel_level(obj.level, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewLevels_SelectedLevel_level(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "items":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedLevel_items(obj.items, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewLevels_SelectedLevel_items(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "description":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedLevel_description(obj.description, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewLevels_SelectedLevel_description(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "image":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewLevels_SelectedLevel_image(obj.image, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_ViewLevels_SelectedLevel_image(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::MobileApps3_Project.ViewModels.LevelViewModel cache_ViewLevels_SelectedLevel = null;
                public void UpdateChildListeners_ViewLevels_SelectedLevel(global::MobileApps3_Project.ViewModels.LevelViewModel obj)
                {
                    if (obj != cache_ViewLevels_SelectedLevel)
                    {
                        if (cache_ViewLevels_SelectedLevel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewLevels_SelectedLevel).PropertyChanged -= PropertyChanged_ViewLevels_SelectedLevel;
                            cache_ViewLevels_SelectedLevel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewLevels_SelectedLevel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewLevels_SelectedLevel;
                        }
                    }
                }
                public void PropertyChanged_ViewLevels_Level(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::MobileApps3_Project.ViewModels.LevelViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MobileApps3_Project.ViewModels.LevelViewModel>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewLevels_Level(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::MobileApps3_Project.ViewModels.LevelViewModel> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::MobileApps3_Project.ViewModels.LevelViewModel>;
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.myPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3:
                {
                    this.InfoPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 8:
                {
                    this.MainList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 9:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                    MainPage_obj9_Bindings bindings = new MainPage_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::MobileApps3_Project.ViewModels.LevelViewModel) element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

