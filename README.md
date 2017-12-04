# gcpe-news-api-client
C# Client for BC Gov News API.
======================

Introduction
----------------
This client is a combination of autorest generated code and human written extensions that allow a C# MVC web application to easily
consume the BC Government News API.  The build script pushes a nuget package, and does not produce any container images.

Repository Map
--------------
- .s2i : Source to image bash assemble script
- **Gov.News.Api.Client**: C# Dotnet Core class Library

Installation
------------
In an OpenShift "Tools" or build project, add the objects contained in the OpenShift\Templates folder.

`oc process -f build-template.json | oc create -f -`

- Once the build template is processed and imported, the following will need to be done:

1.  Set the NUGET_KEY environment variable with your NUGET Key. (if you do not do this, the build will not push the Nuget package to nuget.org)
2. Configure a github hook such that a commit to this repository will trigger a build.
	
Developer Prerequisites
-----------------------

**Gov.News.Api.Client**
- Node.js 
- Visual Studio 2017
- Dotnet Core 2.0

**DevOps**
- OpenShift Container Platform 3.6 or newer (Origin is supported)
- RedHat OpenShift tools
- Docker
- Centos Linux  
- A familiarity with Jenkins

Development
-----------
A Visual Studio 2017 solution has been provided, however Visual Studio Pro is not required to run the build script. 

*Important*

You will need to install Autorest prior to building the source.
`npm install -g autorest`

You may have to run the build more than once initially if using Visual Studio.  

Contribution
------------

Please report any [issues](https://github.com/bcgov/gcpe-news-api-client/issues).

[Pull requests](https://github.com/bcgov/gcpe-news-api-client/pulls) are always welcome.

If you would like to contribute, please see our [contributing](CONTRIBUTING.md) guidelines.

Please note that this project is released with a [Contributor Code of Conduct](CODE_OF_CONDUCT.md). By participating in this project you agree to abide by its terms.

License
-------

    Copyright 2017 Province of British Columbia

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at 

       http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

Maintenance
-----------

This repository is maintained by [GCPE](http://www.gov.bc.ca/).
Click [here](https://github.com/orgs/bcgov/teams/gcpe/repositories) for a complete list of our repositories on GitHub.
