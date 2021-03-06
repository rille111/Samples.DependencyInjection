﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpgradingLegacyApplication.Api.Domain.Services;

namespace UpgradingLegacyApplication.Tests.Domain.Services
{
    [TestClass]
    public class CompanyLoadersTests
    {
        [TestMethod, Ignore] // Fails because of hardcoded dependency inside the loader that we cannot affect from the outside
        public void LegacyJsonCompanyLoader_Should_Load_Companies()
        {
            // Arrange

            // Act
            JsonCompanyLoader.LoadCompanies();

            // Assert
        }
    }
}
