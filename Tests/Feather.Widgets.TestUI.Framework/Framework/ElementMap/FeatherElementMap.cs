﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Core;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.Content;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.ModuleBuilder;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.Navigation;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.Selectors;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.SocialShare;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.Widgets;
using Feather.Widgets.TestUI.Framework.Framework.ElementMap.WidgetTemplates;

namespace Feather.Widgets.TestUI.Framework.Framework.ElementMap
{
    /// <summary>
    /// This is the entry point class for all Feather element maps.
    /// </summary>
    public class FeatherElementMap
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatherElementMap" /> class.
        /// </summary>
        public FeatherElementMap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeatherElementMap" /> class.
        /// </summary>
        /// <param name="find">The find object used to get the elements/controls.</param>
        public FeatherElementMap(Find find)
        {
            this.find = find;
        }

        /// <summary>
        /// Gets the content element map.
        /// </summary>
        /// <value>An initialized instance of generic content element map.</value>
        public ContentMap GenericContent
        {
            get
            {
                if (this.contentMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.contentMap = new ContentMap(this.find);
                }

                return this.contentMap;
            }

            private set
            {
                this.contentMap = value;
            }
        }

        /// <summary>
        /// Gets the navigation element map.
        /// </summary>
        /// <value>An initialized instance of navigation element map.</value>
        public NavigationMap Navigation
        {
            get
            {
                if (this.navigationMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.navigationMap = new NavigationMap(this.find);
                }

                return this.navigationMap;
            }

            private set
            {
                this.navigationMap = value;
            }
        }

        /// <summary>
        /// Gets the social share element map.
        /// </summary>
        /// <value>An initialized instance of navigation element map.</value>
        public SocialShareMap SocialShare
        {
            get
            {
                if (this.socialShareMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.socialShareMap = new SocialShareMap(this.find);
                }

                return this.socialShareMap;
            }

            private set
            {
                this.socialShareMap = value;
            }
        }

        /// <summary>
        /// Gets the content widget designer element map.
        /// </summary>
        /// <value>An initialized instance of content widget designer element map.</value>
        public WidgetDesignerContentMap Widgets
        {
            get
            {
                if (this.widgetDesignerContentMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.widgetDesignerContentMap = new WidgetDesignerContentMap(this.find);
                }

                return this.widgetDesignerContentMap;
            }

            private set
            {
                this.widgetDesignerContentMap = value;
            }
        }

        /// <summary>
        /// Gets the module builder element map.
        /// </summary>
        /// <value>An initialized instance of module builder element map.</value>
        public ModuleBuilderMap ModuleBuilder
        {
            get
            {
                if (this.moduleBuilderMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.moduleBuilderMap = new ModuleBuilderMap(this.find);
                }

                return this.moduleBuilderMap;
            }

            private set
            {
                this.moduleBuilderMap = value;
            }
        }

        /// <summary>
        /// Gets the widget templates element map.
        /// </summary>
        /// <value>An initialized instance of widget template element map..</value>
        public WidgetTemplatesMap WidgetTemplates
        {
            get
            {
                if (this.widgetTemplatesMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.widgetTemplatesMap = new WidgetTemplatesMap(this.find);
                }

                return this.widgetTemplatesMap;
            }

            private set
            {
                this.widgetTemplatesMap = value;
            }
        }

        /// <summary>
        /// Gets the selectors element map.
        /// </summary>
        /// <value>An initialized instance of selectors element map.</value>
        public SelectorsMap Selectors
        {
            get
            {
                if (this.selectorsMap == null)
                {
                    this.EnsureFindIsInitialized();
                    this.selectorsMap = new SelectorsMap(this.find);
                }

                return this.selectorsMap;
            }

            private set
            {
                this.selectorsMap = value;
            }
        }

        private void EnsureFindIsInitialized()
        {
            if (this.find == null)
            {
                throw new NotSupportedException("The element map can't be used without specifying its Find object.");
            }
        }

        private Find find;
        private ContentMap contentMap;
        private NavigationMap navigationMap;
        private SocialShareMap socialShareMap;
        private ModuleBuilderMap moduleBuilderMap;
        private WidgetTemplatesMap widgetTemplatesMap;
        private WidgetDesignerContentMap widgetDesignerContentMap;
        private SelectorsMap selectorsMap;
    }
}
