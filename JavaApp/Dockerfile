# Docker File contains the instructions for the docker to load the required dependencies like the JDK, additional frameworks and packages for executing ur appliaction. Any additional software can also referred from the docker hub. Except the OS, rest of the details required for the software to run must be instructed in the docker file.
FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac SampleFile.java
CMD exec java SampleFile
