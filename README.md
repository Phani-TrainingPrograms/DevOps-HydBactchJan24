# DevOps-HydBactchJan24

## Sub topics:
1. DevOps
2. Docker
3. Jenkins
4. MicroServices
5. Kubernetes. 
### What is DevOps?
- DevOps is a mix of 2 words: Development and Operations.
- There will be 2 teams who collaborate in the PDC. Developer Team and The Operations Team.
- The Developer team will be responsible for Requirement Gathering , Designing and Unit Testing. It also involes in Implementation, Integration of various parts of the Application and finally the deployment. 
- The stake holders of the developer team would be the Product owner, Managers, Team Leads, Senior Programmers, Software programmers and the QA Team (Testers).
- The Operations team will be taking care of Deployment, Automation testing which includes integration and automation, followed by the final deployment into the Customer environment. Parallely the UAT (User Acceptance Tests) process would begin from the Customer end who understands the process very well and the Application requirements. These are the people who use your Application on a day-to-day basis.
- Stake Holders of the Operations team would be the Automation Testers, Product evaluators, UAT Engineers and Customer Users who will use the product. Note that some customer organizations have specialized Engineers to evaluate UR Application to their requirements. 

### Challenges in a regular Application Deployment:
1. Many a time, the Ops team is unaware of the tech parts required for the application: Frameworks, versions, OS versions, dependencies, plugins and many more. Even if a small config modification is required, they might not be aware. They fail to work on it and resolve it. 
2. Integration of multiple config files across the solution will be huge and would take weeks to resolve. 
3. Applications are expected to be created partially, deployed and test them to the current setup, and the developers would continue to work on the next cycle. In this case, the co-operation of the Ops and Dev team was very much required all the time. 
4. The solution for all these problems: Dev + ops => DevOps. 
5. They are supposed to work together from the begining during the sprint planning, do collaborative work on resolving the deployment issues like package versioning, software versioning, config integrations and many more and both the ends are aware of each other's work. With this new setup, app development and deployment happens with help taken from each other and understanding the environment as a whole from both the team.s


### Why devops?
- With Agile Development methodology practised, S/w are small and repeatedly deployed in a phased manner.
- With DevOps, S/w delivery will be fast and easy. It increases the Deployement easiness. As DevOps maintains history of the previous deployments, the DevOps team has expertise that can be utilized in the current deployment and with that experience, they can anticipate future errors and ask the Dev Teams to be carefull on those issues. This makes the future deployements easier. 

### How Apps are deployed in Real time?
- With Agile Development methodology, UR Scrum master will plan the Sprints. The sprint planning includes division of tasks on priority, resource utilization and time for each task. The participants would be 1 Lead, 2 Sr. Engineers, 4 Jr. Engineers and 2(1) Testers. Initially the DevOps Engineer will be made available full time to set up the process of CI/CD feature(Continuous Integration/ Continous Deployement).
There are various tools available like GIT(REPO), Jenkins(CI/CD), Docker(Containers) and K8s(KUBERNETES)

### Real time scenario. 
1. Task: Get the Employee List from the database
2. Requirement: Mock a Database. 
3. Implementation: You create the class that implements the functionality of getting the data from Actual Database. As a Developer, U will create the Unit test cases that calls the object's functions on the Mock Database. The UT code will assert the results and ensure that the expected no of Employees are matching the Employees of the Mocked Database.
4. Once the testing is completed and Internal Reviews(IR) is completed, the authorizied person will push the code into a REPO(Git, BitBucket, TFS...) 
4. The Ops team will use tools like Jenkins to keep watch on the pushes that are made to code repo, from there it automates the process of integration and deployment. 
5. The App is deployed on virtual environment that are created into small containers called as DOCKERS.
6. The management of multiple containers is done by another software K8s. 

### Benifits of Develops:
- Productivity
- Reproducability
- Maintainability. 

### Who needs DevOps?
- DevOps are required for large distributed Computing Apps like E-Commerce Apps and ERP Software where multiple people work at different places and timezones which are usually maintained in a Cloud based Environments. 
- Applications that are created usig Agile Dev Methodologies where U need CD/CI. 

### Major DevOp tools that U should know
1. Git: For Repository Management(Place where U keep UR Code)
2. Jenkins: For CI/CD.
3. Log4J and Splunk for Logging, Analytics and Storing Purposes. 
4. Docker for Virtualization for UR Software
5. K8s for maintaining Clusters of Docker Apps that will run various parts of UR Application as one unit. 

### Docker:
- Docker is a centralized platform for packaging, deploying and executing any appilcation in a closed environment that is created to replacate the actual Environment that is used to execute the Application software. It is more like a VM ware except Docker Container contain only the min environment. 
- It is a software platform that make UR Apps building process smoother which includes creating, running, testing and managing the app. Dockers can even virtualize the OS, Database software, IDEs and many more. Currently, almost all the databases are consumed in the Apps using Dockers only. 
- It uses a concept called CONTAINERS that creates closed Environment and place the App code in it. With these containers, we connect other apps/sw.
- Containers would internally contain all the required dependencies inside it, and creates a virtual environment that matches the real world environment. In Real world, U will install the software and its dependencies on a hardware machine.

#### How to install Docker in UR Environment:
1. Download the MSI file from the Docker website : https://www.docker.com/products/docker-desktop/
2. For Windows OS, install the WSL(Windows Subsystem for Linux) which is pre-requisite for installing docker. To install the WSL U can open the Cmd as Admin and run the following command:
```
wsl --install
```
3. After restarting the machine, U should install the Docker Desktop app that U have downloaded from the Docker Website. If required, U register and then download the setup and install the software. 
4. Docker gets started immediately after installation and one must wait for the docker to start. 
5. If the Cmd is open, restart it. 
#### How to install Mongodb in UR Docker as image:
1. Run the following commands in the order in Command Prompt executed as Admin: 
```
docker pull mongodb/mongodb-community-server
docker run --name mongo -d mongodb/mongodb-community-server:latest
docker container ls
docker exec -it mongo mongosh
show dbs
```

### Steps for installing a Java App as a container in Docker:
1. Create a folder called JavaApp
2. Create the required java files for UR application in it. 
3. Build the app and test it. 
4. Create a Dockerfile(File name is case-sensitive), text file with no extension. Provide the approprite instructions as shared in the docker file. 
5. Run the Docker commands to create the image and execute the Docker Container:
```
docker build -t java-app .
docker run java-app
```
6. Important<b>Options</b>
1. -t => To allocate Virtual Terminal within the container to start UR Program and view the results.
2. -i =>To run the program in interactive mode, usually used when user inputs are expected from the Console window.
--------------------------------------------------------------------------------------------------------------------------------------------
<img width="552" alt="image" src="https://github.com/Phani-TrainingPrograms/DevOps-HydBactchJan24/assets/131134278/12007292-244e-4343-ab69-4db3b4e87fe2">
# Jenkins
### What is Continuous Integration?
- It is an automated process (Orchestration) with a chain of activities that should be peformed when a code is pushed into the REPO and rest of the operations are taken up automatically that helps in pipelining the application build, test and deployment  along with some operational sequences all done without an exclusive resource to monitor. 
- The CIT(CI tool) is responsible to keep track on any code changes that are pushed into the repo. It has a feature of triggering a series of tasks and finally do a post build task before terminating the execution. 
- After the operations are completed in a feel good mode, the post build operation would finally deploy the app on any container(Docker) or a cloud server to finally be consumed by the End Customers. 
- It performs in a sequence where even if one of the tasks are failed, the rest of the operations will be stopped and email notifications will be sent to all the stake holders of the project to bring their attention and resolve it asap. 

## Jenkins?
- Jenkins is basically a server side Application that runs on Apache Tomcat server.It can be executed on multiple platforms. It is one of the most popular CI tool available in the computing world. 
- Jenkins uses a concept called pipelines or group of tasks which work like a chain of operations. It has a continuous process that will monitor the environment all the time. 
- It internally uses a lot of 3rd party tools like Git, Sonarlint, ESLint, JUnit and other software monitoring tools to build, test and monitor the app sequence raise reports for the performance monitoring, enforce coding stds as per the supplied LINTING Software, update the changes, and even send email notifications to all the stake holders about the process seqences. 

## Installation of the JENKINS
- Download the appropriate JDK(version 8 or later)
- Download the Jenkins from the website and install it. 
- During the installation, it will ask for the JRE location which U must select. 
- U can optionally change the port no of the server to suit UR machine requirements. 
- U can start the app at http://localhost:5000 and login into the App using default secret password shared in the below location: 
- Location of the Secret default Admin password: C:\ProgramData\Jenkins\.jenkins\secrets\initialAdminPassword.
- U can reset the password if required. 

## Creating a job in JENKINS
1. U develop the required App inside UR local repository.
2. Click on new item in the dashboard of Jenkins to create a new job.
3. Provide the description, choose the location of the directory in the Advanced Section and select Custom Repository. 
4. In the build steps, select Windows Batch command and provide the commands required to make UR App run. 
```
javac ./FileName.java
java FileName
```
5.  Additional settings like POST Build operations, Build scheduling can be done using the Configuration tool. 
NOTE: Periodic scheduling can be placed on Min, Hour, Day and week. It follows the Cron Time syntax for setting the time and duration.  
--------------------------------------------------------------------------------------
# Kubernetes:
- It is a container management system developed by Google. Its main purpose is helping in managing the containerized apps on various platforms like cloud, virtual servers and local servers. It is said to be one of he most popular containerization management tools.
- It is purely a cloud based Environment which comes with a host of automation tools and servers that are used to maintain and manage the large scale Containers as one UNIT. 
- k8S maintain multiple clusters for managing the components called NODES. 
- K8s uses a concept called Clusters where ach cluster is a repository of 100s of containers grouped into Worker NODES or PODs. Each POD might be a group of containers differed based on a logical grouping. Each container might have one or more microservices in it with its dependencies placed in the container. 
- K8s maintains the services using multiple clusters for the management of nodes. usually any app is available thru' primary cluster. However, at times if the primary cluster fails to load due to maintenance or some failures, then a repo of Secondary cluster will be provided so that the app does not break down. Once the primary cluster is back to business, the cached state of the secondary cluster that is running will be pushed into the primary cluster and will continue with its updated App state. With this, for the end users the App continues to provide its services without any concerns from the user. 

### How K8s work internally?
- Its is a linux based Environment that shares lots of resources required to manage the Complex aps. It is primarily used for Distributed computing Apps where the k8s abstract the underlying hardware resources and offers a std and consistant UI that a DevOps engineer can monitor from a common place. 
- This UI will be available as simple yet allow to perform complex operations. 
- It looks similar to Jenkins where one can monitor multiple apps, clustors and allocate the resoruces required for each of the application. The DevOps person cal determine the amount of resources that each app may required and allocate the resources accordingly. 

### Issues:
1. It needs a heavy infra to showcase the application. 
2. The Complete pipeline is done by a team of testers, DevOps engineers and QAT teams. 
3. It is a collaborative work to make UR services hosted in a K8s Server. It is not user friendly. But there are independent 3rd party UI tools that can manage this infrastructure. 
