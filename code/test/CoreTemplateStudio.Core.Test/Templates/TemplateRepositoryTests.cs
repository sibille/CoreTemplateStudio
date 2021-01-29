﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Linq;
using Microsoft.Templates.Core.Gen;
using Xunit;

namespace Microsoft.Templates.Core.Test.Templates
{
    [Collection("Unit Test Templates")]
    [Trait("ExecutionSet", "Minimum")]
    public class TemplateRepositoryTests
    {
        private readonly TemplatesFixture _fixture;
        private TemplatesRepository _repo;
        private Platform _testPlatform = new Platform("test");

        public TemplateRepositoryTests(TemplatesFixture fixture)
        {
            _fixture = fixture;
        }

        private void SetUpFixtureForTesting(string language)
        {
            _fixture.InitializeFixture(_testPlatform.Id, language);
            _repo = GenContext.ToolBox.Repo;
        }

        [Fact]
        public void GetSupportedProjectTypes()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var projectTemplates = _repo.GetProjectTypes(_testPlatform.Id);

            Assert.Collection(projectTemplates, e1 => e1.Equals("ProjectType"));
        }

        [Fact]
        public void GetFrontendFrameworks()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var frameworks = _repo.GetFrontEndFrameworks(_testPlatform.Id, "pt1");

            Assert.Collection(frameworks, e1 =>
            {
                Assert.Equal("TestFramework", e1.Name);
                Assert.Equal(FrameworkTypes.FrontEnd.ToString().ToLower(), e1.Tags["type"]);
            });
        }

        [Fact]
        public void GetBackendFrameworks()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var frameworks = _repo.GetBackEndFrameworks(_testPlatform.Id, "pt3");

            Assert.Collection(frameworks, e1 =>
            {
                Assert.Equal("TestFramework", e1.Name);
                Assert.Equal(FrameworkTypes.BackEnd.ToString().ToLower(), e1.Tags["type"]);
            });
        }

        [Fact]
        public void GetPages_OnlyFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var pages = _repo.GetTemplatesInfo(TemplateType.Page, _testPlatform, "pt1", "fx1");

            Assert.Collection(
                pages,
                p1 =>
                {
                    Assert.Equal("PageTemplate", p1.Name);
                });
        }

        [Fact]
        public void GetPages_BackendAndFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var pages = _repo.GetTemplatesInfo(TemplateType.Page, _testPlatform, "pt3", "fx1", "fx3");

            Assert.Collection(
                pages,
                p1 =>
                {
                    Assert.Equal("PageTemplate", p1.Name);
                });
        }

        [Fact]
        public void GetPages_NoMatches()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var pages = _repo.GetTemplatesInfo(TemplateType.Page, _testPlatform, "pt1", "fx1", "fx4");

            Assert.Empty(pages);
        }

        [Fact]
        public void GetFeatures_OnlyFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var features = _repo.GetTemplatesInfo(TemplateType.Feature, _testPlatform, "pt1", "fx1");

            Assert.Contains(features, f => f.Name == "FeatureTemplate");
        }

        [Fact]
        public void GetFeatures_BackendAndFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var features = _repo.GetTemplatesInfo(TemplateType.Feature, _testPlatform, "pt3", "fx1", "fx3");

            Assert.Collection(
                features,
                f1 =>
                {
                    Assert.Equal("FeatureTemplate", f1.Name);
                });
        }

        [Fact]
        public void GetFeatures_NoMatches()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var features = _repo.GetTemplatesInfo(TemplateType.Feature, _testPlatform, "pt1", "fx1", "fx4");

            Assert.Empty(features);
        }

        [Fact]
        public void GetServices_OnlyFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var services = _repo.GetTemplatesInfo(TemplateType.Service, _testPlatform, "pt1", "fx1");

            Assert.Collection(
                services,
                f1 =>
                {
                    Assert.Equal("ServiceTemplate", f1.Name);
                });
        }

        [Fact]
        public void GetServices_BackendAndFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var services = _repo.GetTemplatesInfo(TemplateType.Service, _testPlatform, "pt3", "fx1", "fx3");

            Assert.Collection(
                services,
                f1 =>
                {
                    Assert.Equal("ServiceTemplate", f1.Name);
                });
        }

        [Fact]
        public void GetServices_NoMatches()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var services = _repo.GetTemplatesInfo(TemplateType.Service, _testPlatform, "pt1", "fx1", "fx4");

            Assert.Empty(services);
        }

        [Fact]
        public void GetTestings_OnlyFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var testing = _repo.GetTemplatesInfo(TemplateType.Testing, _testPlatform, "pt1", "fx1");

            Assert.Collection(
                testing,
                f1 =>
                {
                    Assert.Equal("TestingTemplate", f1.Name);
                });
        }

        [Fact]
        public void GetTestings_BackendAndFrontEndFrameworkFilter()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var testing = _repo.GetTemplatesInfo(TemplateType.Testing, _testPlatform, "pt3", "fx1", "fx3");

            Assert.Collection(
                testing,
                f1 =>
                {
                    Assert.Equal("TestingTemplate", f1.Name);
                });
        }

        [Fact]
        public void GetTestings_NoMatches()
        {
            SetUpFixtureForTesting(ProgrammingLanguages.CSharp);

            var testing = _repo.GetTemplatesInfo(TemplateType.Testing, _testPlatform, "pt1", "fx1", "fx4");

            Assert.Empty(testing);
        }
    }
}
