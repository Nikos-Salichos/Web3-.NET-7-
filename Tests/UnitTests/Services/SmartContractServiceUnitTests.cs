﻿using Application.Interfaces;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Moq;
using Xunit;

namespace Tests.UnitTests.Repositories
{
    [Trait("SmartContractsService", "UnitTests")]
    public class SmartContractServiceUnitTests
    {
        private static readonly Mock<ISmartContractService> _mockSmartContractService = new Mock<ISmartContractService>();

    }
}
