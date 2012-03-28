using System;
using NUnit.Framework;
using System.Reflection;

public abstract class TestFixtureBase
{
	private static bool HasBeenLoaded = false;
	
	[TestFixtureSetUp]
	public void Bootstrap()
	{
		if (!HasBeenLoaded)
		{
			Assembly.LoadFile("libhowitworks-tests-input.dll");
			HasBeenLoaded = true;
		}
		
		this.FixtureSetup();
	}
	
	public virtual void FixtureSetup()
	{
	}
}