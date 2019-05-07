# DiSamples.NetFramework

## Overview
What is dependancy injection?





This project is designed to demonstrate dependancy injection for .NET Framework.

The following containers will be demonstrated:
- Unity
- [Autofac](https://autofac.org/)
- [Ninject](http://www.ninject.org/)
- [Castle Windsor](http://www.castleproject.org/projects/windsor/)
- [StructureMap](http://structuremap.github.io/)

The following types of configuration will be demonstrated:
- Fluent
- Configuration files

The following types of injection will be demonstrated:
- Contructor Injection
- Property Injection
- Method Injection

## Samples
### Comparison
The samples in the Comparison folder are used to demonstrate a side-by-side comparison between various injection containters. 

All projects share a common Domain class library. This project contains an interface (IEmployee) and 3 concrete implementations (FullTimeEmployee, ContractEmployee, NullEmployee).

Each project is setup as close to identical as possible so you can focus on the syntax differences between injection containers. 

Each project has a corresponding Unit Test project to validate functionality of the associated injection container.

Each project contains the following files:
- Authenticator - Used to demonstrate property injection

- DiHelper - Used to demonstrate how to instantiate a container with configuration and fluent 
- Factory - Used to demonstrate how to resolve instances based on variety of configurations
- PayrollProcessor - Used to demonstrate constructor injection
- TimeTracker - Used to demonstrate method injection
- Worker - Used to demonstrate to resolve objects that have dependancies

### Unity
The samples in the Unity folder...

## Reference
- [Configuration Comparison of Dependency Injection Containers (IOC)](https://codingsight.com/configuation-comparison-dependency-injection-containers/)
