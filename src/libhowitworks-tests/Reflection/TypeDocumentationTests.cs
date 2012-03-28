using System;
using NUnit.Framework;
using HowItWorks.Reflection;
using Missing.Reflection;

[TestFixture]
public class TypeDocumentationTests : TestFixtureBase
{
	#region Instantiation
	[Test]
	public void EverythingIsInstantiated()
	{
		TypeDocumentation doc = new TypeDocumentation();
		
		Assert.IsNotNull(doc.Constructors);
		Assert.IsEmpty(doc.Constructors);
		
		Assert.IsNotNull(doc.Methods);
		Assert.IsEmpty(doc.Methods);
		
		Assert.IsNotNull(doc.Properties);
		Assert.IsEmpty(doc.Properties);
	}
	#endregion
	
	#region Populate
	private string karma = "Beliefs.Budhism.Karma";
	
	[Test]
	public void Populate_Simple()
	{
		Type t = TypeHelper.GetType(this.karma);
		
		TypeDocumentation doc = new TypeDocumentation();
		doc.Populate(t);
		
		Assert.AreEqual("Karma", doc.Name, "Name is wrong");
		Assert.AreEqual("Beliefs.Budhism", doc.Namespace, "Namespace is wrong");
		Assert.AreEqual("libhowitworks-tests-input.dll", doc.Assembly, "Assembly is wrong");
	}
	
	[Test]
	public void Populate_OneConstructor()
	{
		Type t = TypeHelper.GetType(this.karma);
		
		TypeDocumentation doc = new TypeDocumentation();
		doc.Populate(t);
		
		Assert.AreEqual(1, doc.Constructors.Count, "Number of constructors is wrong");
		Assert.IsTrue(doc.Constructors[0].WrappedElement.IsConstructor, "The wrapped element should be a constructor");
		
		Assert.IsEmpty(doc.Constructors[0].WrappedElement.GetParameters(), "The constructor should not take any parameters");
	}
	
	[Ignore]
	[Test]
	public void Populate_MultipleConstructors()
	{
	}
	
	[Test]
	public void Populate_Methods()
	{
		Type t = TypeHelper.GetType(this.karma);
		
		TypeDocumentation doc = new TypeDocumentation();
		doc.Populate(t);
		
		
		/*
		 * DidSomething   <-- this is the one we are looking for
		 * Equals
		 * GetHashCode
		 * GetType
		 * ToString
		 */
		
		Assert.AreEqual(1+4, doc.Methods.Count, "Number of methods is wrong");
		MethodDocumentation method = doc.Methods[0];
		
		Assert.IsTrue(method.WrappedElement.IsPublic, "The wrapped element should be a public method");
		Assert.AreEqual(1, method.Parameters.Count, "The method should take 1 parameter");
		Assert.AreEqual("DidSomething", method.WrappedElement.Name, "Name of the method is wrong");
	}
	#endregion
}