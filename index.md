# Welcome to CDS ISA Training (June 2019) 
[https://aka.ms/isat2019](https://aka.ms/isat2019)

Our hands-on technical training will consist of three session options. Pick one.

1. Room 31/P106-Whistler - A **Level 200** [IoT Edge hands-on lab](https://github.com/rangv/azureiotedgelab) written by Ranga V.  
 This step-by-step hands-on lab session is aimed at those of you who want to familiarize yourselves with:
    * Module 1 - Learn About IoT Edge Pattern
    * Module 2 - Create IoT HuB using VSCode
    * Module 3 - Deploy Azure IoT Edge Enabled Linux VM
    * Module 4 - Add an Edge Module and Deploy
    * Module 5 - Deploy Azure Stream Analytics on Edge
    * Module 6 - Deploy Azure Function on Edge

2. Room 31/36 - A **Level 300** instructor-led live IoT Edge module coding workshop **for experienced developers only**.  
 This session is for those of you who wish to develop a custom IoT Edge module in Python.
    * How do you know if you are an experience developer? Have you written more than 200 lines of code in the last 2 years? If not, this is not for you, see Level 200.
    * This session will move at a fast pace with assumed understanding of development concepts.
    * You will develop the module alongside the instructor in a live-coding session.
    * Familiarity with Python is strongly recommended. This is **NOT** an intro to Python.

3. Room 31/P106-Whistler  - A **Level 400** IoT Edge module development challenge.  
 This challenge will involve writing a custom IoT Edge module from scratch in Python or C# to ingest IoT data from a live endpoint.
    * Self-directed, not instructor-led.
    * You will be provided the challenge details **here** the morning of the challenge.
    * You can run IoT Edge on a physical device (e.g. Raspberry Pi) or as a software gateway on a VM or your laptop.
      * Ensure your IoT Edge device is setup and configured ahead of time.
    * You will complete the challenge yourself; no partners.
    * You will have three (3) hours to complete the challenge.
    * The first to complete the challenge will receive the inaugural (and coveted) CDS IoT Dev Champ trophy

## Prerequisites

Please install the following prior to participating.

1. Install [VSCode](https://code.visualstudio.com/) and the following Microsoft extensions:
    * Azure IoT Device Workbench
    * Azure IoT Edge
    * Azure IoT Hub Toolkit
    * Azure IoT Tools
    * C#
    * Python
1. Install [Python 3.7](https://www.python.org/downloads/)
    * Ensure PIP is also [installed](https://www.liquidweb.com/kb/install-pip-windows/) (normally it is installed with Python) 
    * Ensure Python is a part of your [PATH](https://geek-university.com/python/add-python-to-the-windows-path/) system variable.
1. Install Docker Desktop - Go To [Docker](https://docs.docker.com/install/) to Install Docker for Windows or Mac. 
1. Install .NET Core
    * Open a browser and navigate to [.NET Downloads](https://dotnet.microsoft.com/download).
    * Select the **Windows** tab and click **Download .NET Core SDK**
      * **Note**: We are using .NET Core **not** .NET Framework.
    Once the download has completed, continue.
    * Launch the downloaded Microsoft .NET Core installer and click **Install**.
    When the **User Access Control** prompt is displayed, click **Yes**.
    * Once the installation has completed, click **Close**.
    * Open a **Command prompt** and enter the following command:
    ```script
    dotnet --version
    ```
    You should see a response similar to:
    ```script
    C:\>dotnet --version
    2.2.100
    ```
1. Reboot
