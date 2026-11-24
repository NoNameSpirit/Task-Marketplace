using Xunit;

namespace Task_Marketplace.Tests.Integration.Infrastructure.Fixtures;

[CollectionDefinition("DBCollection")]
public class DatabaseCollection : ICollectionFixture<IntegrationTestFixture>
{
}