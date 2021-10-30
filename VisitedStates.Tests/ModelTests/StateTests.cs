using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VisitedStates.Models;
using System;

namespace VisitedStates.Tests
{
  [TestClass]
  public class StateTests 
  {
    [TestMethod]
    public void StateConstructor_CreateInstanceOfState_State()
    {
      State newState = new State();
      Assert.AreEqual(typeof(State), newState.GetType());
    }
  }
}