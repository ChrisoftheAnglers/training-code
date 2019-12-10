using System;
using Xunit;
using Microsoft.Extensions.Logging;
using Devops.Client.Controllers;

namespace Devops.Test
{
  public class ClientTest
  {
    private readonly ILogger<HomeController> logger = LoggerFactory.Create(o => o.SetMinimumLevel(LogLevel.Debug)).CreateLogger<HomeController>();
    [Fact]
    public void Test_IndexPage()
    {
      // arrange
      var home = new HomeController(logger);
      // act
      var index = home.Index();

      // assert
      Assert.NotNull(index);
    }
    [Fact]
    public void Test_PrivacyPage()
    {
      // arrange
      var home = new HomeController(logger);
      // act
      var view = home.Privacy();

      // assert
      Assert.NotNull(view);
    }
  }
}