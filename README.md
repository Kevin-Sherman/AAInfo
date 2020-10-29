<!--
*** Thanks for checking out this README Template. If you have a suggestion that would
*** make this better, please fork the repo and create a pull request or simply open
*** an issue with the tag "enhancement".
*** Thanks again! Now go create something AMAZING! :D
-->





<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/Metadev-Digital/AAInfo">
    <img src="https://www.metadevdigital.com/images/acr.png" alt="Logo">
  </a>

  <h3 align="center">AAInfo</h3>

  <p align="center">
    Acrelec America branded about page with built in error reporting system. 
    <br />
    <a href="https://github.com/Metadev-Digital/AAInfo"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://www.nuget.org/packages/AAInfo/">Download the Package</a>
    ·
    <a href="https://github.com/Metadev-Digital/AAInfo/issues">Report Bug</a>
    ·
    <a href="https://github.com/Metadev-Digital/AAInfo/issues">Request Feature</a>
  </p>
</p>



<!-- TABLE OF CONTENTS -->
## Table of Contents

* [About the Project](#about-the-project)
  * [Built With](#built-with)
* [Getting Started](#getting-started)
  * [Prerequisites](#prerequisites)
  * [Installation](#installation)
* [Usage](#usage)
* [Roadmap](#roadmap)
* [Contributing](#contributing)
* [License](#license)
* [Contact](#contact)
* [Acknowledgements](#acknowledgements)



<!-- ABOUT THE PROJECT -->
## About The Project

<img src="https://www.metadevdigital.com/acrelec/aainfo/proj.png" alt="AAInfo Download">

AAInfo serves a customized about information panel to any Windows Frame Application served in C#. This tool was created during a refactoring of different applications created for Acrelec America. By creating this as it's own stand-alone tool, AAInfo allows other software to outsource important services like software description and error reporting to it rather than requiring it to be iterated upon over and over again.

Services contained in AAInfo:
* An About frame that displays branding and delves into the rights, restrictions, and descriptions of the software that includes AAInfo.
* Error reporting meant for users to directly submit trouble tickets to developers to keep the tools up and running day-to-day.
* An Error frame that allows the messages to be customized to include as much detail as possible from the user.

Of course, no one solution will serve all projects since your needs may be different. So I'll be adding more in the near future. You may also suggest changes by forking this repo and creating a pull request or opening an issue.

### Built With

* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [HTML5](https://html.com/html5/)
* [Packaged with NuGet](https://www.nuget.org/)


<!-- GETTING STARTED -->
## Getting Started

Import the tool through the [NuGet Package Manager](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio) inside of Visual Studio, or through any other IDE.

### Prerequisites

Windows Forms Application .Net Framework Project

### Installation

1. Download the .nupkg *OR* Import from [NuGet Package Manager](https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio) inside of Visual Studio, or through any other IDE.

2. Create an Email, ErrorReporter, and InfoDisplayer object

<!-- USAGE EXAMPLES -->
## Usage

### Email

The **Email class** is used to create a repository of email information that is used to ultimately send the messages during error reports. This is created on project creation to handle a possibility of a custom **TO** and **FROM** addresses. Constructors are listed below.

* A non-default to and from email address are required if you wish your error reports to be sent to an email you can access.
* ErrorReporter class creates a default email class if one is not provided on object creation.

<img src="https://www.metadevdigital.com/acrelec/aainfo/snipet1.png" alt="Email class constructors">
  
### ErrorReporter

The **ErrorReporter class** is used to generate a Windows Frame containing a configured email allowing a user to type a message and send it to a technician through the application itself. It creates a default *Email class* object unless provided one on object creation.

To display the form, calls to the function .showForm() can be made.

* To configure the subject to the specific software, add the software name during construction else it will show with default branding.

<img src="https://www.metadevdigital.com/acrelec/aainfo/snipet2.png" alt="ErrorReporter class constructors">

### InfoDisplayer

The **InfoDisplayer** class is used to generate a Windows Frame containing a specifically formatted about page for the software AAInfo is bundled with as well as an option for the user to issue a report, generating an instance of an ErrorReporter as well. If a preconfigured *ErrorReporter* object is not provided to *InfoDisplayer* during construction, it will contain a default *Email* class object as well as a default branding for error messages.

Custom configuration is given in the form of *software name, company name, software licensing, & software description*. Leading/trailing spaces are not required at the begining or ending of a phrase. Description is used in the following context "&Softwarename is used to $Softwaredesc." To display the form, calls to the function .showForm() can be made.

* A preconfigured *ErrorReporter* and *Email* class objects are required during construction of an InfoDisplayer for error messages to be sent to an email address you can access.

<img src="https://www.metadevdigital.com/acrelec/aainfo/snipet3.png" alt="InfoDisplayer class constructors">

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/Metadev-Digital/AAInfo/issues) for a list of proposed features (and known issues).



<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.



<!-- CONTACT -->
## Contact

Kevin Sherman - [@CMetadev](https://twitter.com/cmetadev) - contact@metadevdigital.com

Project Link: [https://github.com/Metadev-Digital/AAInfo](https://github.com/Metadev-Digital/AAInfo)



<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements
* [Img Shields](https://shields.io)
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template/blob/master/README.md)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->


[contributors-shield]: https://img.shields.io/github/contributors/metadev-digital/aainfo.svg?style=flat-square
[contributors-url]: https://github.com/Metadev-Digital/AAInfo/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/metadev-digital/aainfo.svg?style=flat-square
[forks-url]: https://github.com/Metadev-Digital/AAInfo/network/members
[stars-shield]: https://img.shields.io/github/stars/metadev-digital/aainfo.svg?style=flat-square
[stars-url]: https://github.com/Metadev-Digital/AAInfo/stargazers
[issues-shield]: https://img.shields.io/github/issues/metadev-digital/aainfo.svg?style=flat-square
[issues-url]: https://github.com/Metadev-Digital/AAInfo/issues
[license-shield]: https://img.shields.io/github/license/metadev-digital/aainfo.svg?style=flat-square
[license-url]: https://github.com/Metadev-Digital/AAInfo/blob/master/LICENSE
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=flat-square&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/company/metadev-digital/
[product-screenshot]: https://www.metadevdigital.com/images/proj.png
