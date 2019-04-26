# Welcome to CDS ISA Training (June 2019)
## https://aka.ms/isat2019

Our hands-on technical training will consist of three options. Pick one.

1. A **Level 200** [IoT Edge hands-on lab](https://github.com/rangv/azureiotedgelab) written by Ranga V.  
 This step-by-step hands-on lab is aimed at those of you who want to familiarize yourselves with:
    * Module 1 - Learn About IoT Edge Pattern
    * Module 2 - Create IoT HuB using VSCode
    * Module 3 - Deploy Azure IoT Edge Enabled Linux VM
    * Module 4 - Add an Edge Module and Deploy
    * Module 5 - Deploy Azure Stream Analytics on Edge
    * Module 6 - Deploy Azure Function on Edge
 
2. A **Level 300** instructor-led live IoT Edge module coding workshop.  
 The lab is for those of you who wish to develop a custom IoT Edge module in C#.
    * You will develop the module alongside the instructor in a live-coding session. 
    * Some familiarity with C# is strongly recommended. This is NOT an intro to C#.

3. A **Level 400** IoT Edge module development challenge.  
 The challenge will involve writing a custom module from scratch in Python or C# to ingest IoT data from a live endpoint.
    * There is no instructor. No detailed instructions. 
    * You will be provided the challenge details on the day of.
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
1. Install Docker - Go To [Docker](https://docs.docker.com/install/) to Install Docker for Windows or Mac. 
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
