
# .NET Client Library for Ready! API TestServer

This repository contains source file for the .NET Client library for [Ready! API TestServer](http://readyapi.smartbear.com/testserver/start) <html>&ndash;</html> a standalone server that exposes APIs for running API tests. 

TestServer receives and runs *test recipes* <html>&ndash;</html> special JSON requests that describe API test actions to be executed. You can use this library to create and run test recipes from within your .Net code, without installing Ready! API or any other API testing tool on your computer.

## Requirements

The .NET Client Library requires Microsoft .NET Framework 4.5 or later.

## Quick Guide

1. Download the repository and run the provided .bat files. They will compile the library:
 - First, run *<root folder>/io-swagger-client/compile.bat*
 - Then, run *<root folder>/ready-api-testserver-client/compale.bat*


2. Add all dlls from the following folders to your .NET project:
 - *<root folder>/io-swagger-client/bin*
 - *<root folder>/ready-api-testserver-client/bin*


2. Create a test recipe in Visual Studio:

	```cs
   static void Main(string[] args)
      {
         TestRecipe recipe = TestRecipeBuilder.NewTestRecipe()/* Creates a new test recipe. */
                     .AddStep(TestSteps.RestRequest() /* Creates a new test step (REST Request). */
                           .Get("http://maps.googleapis.com/maps/api/geocode/json") /* Specifies the GET method type and a request endpoint. */
                           .AddQueryParameter("address", "1600+Amphitheatre+Parkway,+Mountain+View,+CA")  /* Parameter string. */
                           .AddQueryParameter("sensor", "false")  /* Parameter string. */
                           .AddAssertion(Assertions.JsonPathContent("$.results[0].address_components[1].long_name", "Amphitheatre Parkway") /* Create a JsonPath Content assertion. The required assertion parameters are specified in the assertion constructor.*/
                                 .AllowWildcards() /* Specifies additional assertion parameters. */
                           )
                     )
                     .BuildTestRecipe(); /* Important: builds a test recipe for execution. */
         RecipeExecutor recipeExecutor = new RecipeExecutor(Scheme.HTTPS, "MyTestServer", 8443); /* Creates the runner object and specifies the TestServer address for it. */
         //RecipeExecutor recipeExecutor = new RecipeExecutor("MyTestServer", 8443); /* Creates the runner object and specifies the TestServer address for it. */
         recipeExecutor.SetCredentials("John", "Smith"); /* Adds basic authentication for requests to the TestServer. */
         Execution execution = recipeExecutor.ExecuteRecipe(recipe);
         System.Console.WriteLine(execution.CurrentReport.ToString());
      }
	```


3. Run your code.

## Using the .NET Client Library
<html>&rArr;</html> **[Creating Code-Based Recipes: Tutorial](http://readyapi.smartbear.com/testserver/tutorials/code_based/start)** <html><span style="color : #555;">(in Ready! API TestServer documentation)</span></html>


### Learn More
[Ready! API TestServer](http://readyapi.smartbear.com/testserver/intro/about)

[Ready! API](http://readyapi.smartbear.com/start)

- - - 
<html>&copy;</html> 2016 SmartBear Software

