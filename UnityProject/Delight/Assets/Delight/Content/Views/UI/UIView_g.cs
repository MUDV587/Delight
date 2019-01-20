// Internal view logic generated from "UIView.xml"
#region Using Statements
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace Delight
{
    public partial class UIView : SceneObjectView
    {
        #region Constructors

        public UIView(View parent, View layoutParent = null, string id = null, Template template = null, Action<View> initializer = null) :
            base(parent, layoutParent, id, template ?? UIViewTemplates.Default, initializer)
        {
        }

        public UIView() : this(null)
        {
        }

        static UIView()
        {
            var dependencyProperties = new List<DependencyProperty>();
            DependencyProperties.Add(UIViewTemplates.Default, dependencyProperties);

            dependencyProperties.Add(RectTransformProperty);
            dependencyProperties.Add(WidthProperty);
            dependencyProperties.Add(HeightProperty);
            dependencyProperties.Add(OverrideWidthProperty);
            dependencyProperties.Add(OverrideHeightProperty);
            dependencyProperties.Add(AlignmentProperty);
            dependencyProperties.Add(MarginProperty);
            dependencyProperties.Add(OffsetProperty);
            dependencyProperties.Add(OffsetFromParentProperty);
            dependencyProperties.Add(PivotProperty);
            dependencyProperties.Add(LayoutRootProperty);
            dependencyProperties.Add(DisableLayoutUpdateProperty);
        }

        #endregion

        #region Properties

        public readonly static DependencyProperty<UnityEngine.RectTransform> RectTransformProperty = new DependencyProperty<UnityEngine.RectTransform>("RectTransform");
        public UnityEngine.RectTransform RectTransform
        {
            get { return RectTransformProperty.GetValue(this); }
            set { RectTransformProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> WidthProperty = new DependencyProperty<Delight.ElementSize>("Width");
        public Delight.ElementSize Width
        {
            get { return WidthProperty.GetValue(this); }
            set { WidthProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> HeightProperty = new DependencyProperty<Delight.ElementSize>("Height");
        public Delight.ElementSize Height
        {
            get { return HeightProperty.GetValue(this); }
            set { HeightProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> OverrideWidthProperty = new DependencyProperty<Delight.ElementSize>("OverrideWidth");
        public Delight.ElementSize OverrideWidth
        {
            get { return OverrideWidthProperty.GetValue(this); }
            set { OverrideWidthProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementSize> OverrideHeightProperty = new DependencyProperty<Delight.ElementSize>("OverrideHeight");
        public Delight.ElementSize OverrideHeight
        {
            get { return OverrideHeightProperty.GetValue(this); }
            set { OverrideHeightProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementAlignment> AlignmentProperty = new DependencyProperty<Delight.ElementAlignment>("Alignment");
        public Delight.ElementAlignment Alignment
        {
            get { return AlignmentProperty.GetValue(this); }
            set { AlignmentProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementMargin> MarginProperty = new DependencyProperty<Delight.ElementMargin>("Margin");
        public Delight.ElementMargin Margin
        {
            get { return MarginProperty.GetValue(this); }
            set { MarginProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementMargin> OffsetProperty = new DependencyProperty<Delight.ElementMargin>("Offset");
        public Delight.ElementMargin Offset
        {
            get { return OffsetProperty.GetValue(this); }
            set { OffsetProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.ElementMargin> OffsetFromParentProperty = new DependencyProperty<Delight.ElementMargin>("OffsetFromParent");
        public Delight.ElementMargin OffsetFromParent
        {
            get { return OffsetFromParentProperty.GetValue(this); }
            set { OffsetFromParentProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<UnityEngine.Vector2> PivotProperty = new DependencyProperty<UnityEngine.Vector2>("Pivot");
        public UnityEngine.Vector2 Pivot
        {
            get { return PivotProperty.GetValue(this); }
            set { PivotProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<Delight.LayoutRoot> LayoutRootProperty = new DependencyProperty<Delight.LayoutRoot>("LayoutRoot");
        public Delight.LayoutRoot LayoutRoot
        {
            get { return LayoutRootProperty.GetValue(this); }
            set { LayoutRootProperty.SetValue(this, value); }
        }

        public readonly static DependencyProperty<System.Boolean> DisableLayoutUpdateProperty = new DependencyProperty<System.Boolean>("DisableLayoutUpdate");
        public System.Boolean DisableLayoutUpdate
        {
            get { return DisableLayoutUpdateProperty.GetValue(this); }
            set { DisableLayoutUpdateProperty.SetValue(this, value); }
        }

        #endregion
    }

    #region Data Templates

    public static class UIViewTemplates
    {
        #region Properties

        public static Template Default
        {
            get
            {
                return UIView;
            }
        }

        private static Template _uIView;
        public static Template UIView
        {
            get
            {
#if UNITY_EDITOR
                if (_uIView == null || _uIView.CurrentVersion != Template.Version)
#else
                if (_uIView == null)
#endif
                {
                    _uIView = new Template(SceneObjectViewTemplates.SceneObjectView);
                    Delight.UIView.WidthProperty.SetDefault(_uIView, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.UIView.HeightProperty.SetDefault(_uIView, new ElementSize(1f, ElementSizeUnit.Percents));
                    Delight.UIView.MarginProperty.SetDefault(_uIView, new ElementMargin(0f, 0f, 0f, 0f));
                    Delight.UIView.OffsetProperty.SetDefault(_uIView, new ElementMargin(0f, 0f, 0f, 0f));
                    Delight.UIView.OffsetFromParentProperty.SetDefault(_uIView, new ElementMargin(0f, 0f, 0f, 0f));
                }
                return _uIView;
            }
        }

        #endregion
    }

    #endregion
}