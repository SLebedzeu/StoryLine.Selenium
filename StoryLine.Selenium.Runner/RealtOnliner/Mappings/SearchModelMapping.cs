﻿using StoryLine.Selenium.Getters;
using StoryLine.Selenium.Mappings;
using StoryLine.Selenium.Runner.RealtOnliner.Models;
using StoryLine.Selenium.Runner.RealtOnliner.Pages;
using StoryLine.Selenium.Setters;

namespace StoryLine.Selenium.Runner.RealtOnliner.Mappings
{
    public class SearchModelMapping : ModelMapping<SearchModel>
    {
        public override void Configure()
        {
            Property(x => x.Text, EstatePage.SearchTextBox, new TextValueGetter(), new TextValueSetter());
        }
    }
}
