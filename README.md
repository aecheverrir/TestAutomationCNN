# Test Automation for CNN

**Implementation time: 8hrs**

## Table of Contents

- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Setup](#setup)
- [Testing](#testing)
- [License](#license)

---

## Prerequisites

- Visual Studio (with .NET Core 2.2)
- Google Chrome
- Git


## Installation

- Clone or download this repository
- Search for the TestAutomationCNN.sln file (at the main folder, "TestAutomationCNN") and open it with VisualStudio


## Setup

Testing requires a web driver, which depends on your chrome version and operating system.
Configure the web driver path: 
- On Visual Studio, head to the SearchTesting.cs file and open it.
- Change the `chromeDriverPath` constant value to target your operating system and chrome version (versions 73-76 are allready included in the project for both windows and macOS)
 
 
**If your operating system + chrome version is not included:**
- Download the driver at: http://chromedriver.chromium.org/downloads
- Extract it
- Add the chromedriver.exe at an appropriate location within the "webdrivers" folder
- Change the path to that relative path


## Testing

In order to run tests, make sure you have built the project then head to the TestExplorer window. In that window, you may select which test to run by right clicking a test and selecting the "Run Selected Tests" option.

This will automatically open a Chrome window, run the test and close the driver once it's done.


## License

[![License](http://img.shields.io/:license-mit-blue.svg?style=flat-square)](http://badges.mit-license.org)

- **[MIT license](http://opensource.org/licenses/mit-license.php)**
- Copyright 2019 © 
