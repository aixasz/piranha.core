/*
 * Copyright (c) 2017 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/tidyui/coreweb
 * 
 */

using Piranha.AttributeBuilder;
using Piranha.Models;
using Piranha.Extend.Fields;
using System.Collections.Generic;

namespace Piranha.Manager
{
    /// <summary>
    /// Test page
    /// </summary>
    [PageType(Title = "Test page")]
    public class TestPage : Page<TestPage>
    {
        public class HeaderRegion
        {
            [Field(Options = FieldOption.HalfWidth)]
            public StringField Title { get; set; }

            [Field(Title = "Sub title", Options = FieldOption.HalfWidth)]
            public StringField SubTitle { get; set; }

            [Field(Title = "Background image")]
            public ImageField Background { get; set; }

            [Field]
            public HtmlField Body { get; set; }
        }

        [Region]
        [RegionDescription("The Header shows an optional Hero banner on the page. If you leave all fields empty the header will be omitted from the current page.")]
        public HeaderRegion Header { get; set; }
    }
}