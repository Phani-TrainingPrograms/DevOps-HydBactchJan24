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
