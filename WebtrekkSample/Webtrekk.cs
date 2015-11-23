using System;
using XamarinWebtrekkBindings;

namespace WebtrekkSample
{
    public class Webtrekk
    {
        private static readonly Lazy<WebtrekkProxy> lazy =
            new Lazy<WebtrekkProxy>(() => new WebtrekkProxy());

        public static WebtrekkProxy Instance { get { return lazy.Value; } }

        private Webtrekk()
        {
        }
    }
}
