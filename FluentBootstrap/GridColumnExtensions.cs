﻿using FluentBootstrap.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap
{
    public static class GridColumnExtensions
    {
        public static TThis Xs<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-xs-", value);
        }

        public static TThis Sm<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-sm-", value);
        }

        public static TThis Md<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-md-", value);
        }

        public static TThis Lg<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-lg-", value);
        }

        public static TThis XsOffset<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-xs-offset-", value);
        }

        public static TThis SmOffset<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-sm-offset-", value);
        }

        public static TThis MdOffset<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-md-offset-", value);
        }

        public static TThis LgOffset<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-lg-offset-", value);
        }

        public static TThis XsPush<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-xs-push-", value);
        }

        public static TThis SmPush<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-sm-push-", value);
        }

        public static TThis MdPush<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-md-push-", value);
        }

        public static TThis LgPush<TModel, TThis>(this Component<TModel, TThis> component, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            return SetClass(component, "col-lg-push-", value);
        }

        private static TThis SetClass<TModel, TThis>(Component<TModel, TThis> component, string prefix, int? value)
            where TThis : Tag<TModel, TThis>, IHasGridColumnExtensions
        {
            TThis tag = component.GetThis();
            tag.CssClasses.RemoveWhere(x => x.StartsWith(prefix));
            if (value != null)
            {
                if (value <= 0)
                    value = 1;
                if (value > Bootstrap.GridColumns)
                    value = Bootstrap.GridColumns;
                tag.CssClasses.Add(prefix + value.Value);
            }
            return tag;
        }
    }
}