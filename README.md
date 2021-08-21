# kidmanDockerSeleniumCourse
Repository to implement the homeworks requested on https://testautomationu.applitools.com/scaling-tests-with-docker

## Pre-requisites
```
sudo apt-get install docker-compose
docker pull selenium/hub
docker pull selenium/node-chrome
```

## Basic theory
* Container need to be started using images.
* We obtain the images from an image repository called hub.docker.com using pull/push commands.
* A docker engine is...
* A docker cluster is... 
* A collection of docker engines joined into a cluster is called a swarm.
* Each docker container inside a swarm is called a node and can be either a manager or a worker.
* The job of the manager is to maintain the capacity of the swarm by replacing unavailable workers.
* A docker stack is a group of services that are scaled together (??)

## Commands
* Setup containers defined on the docker-compose.yml: `docker-compose up -d`
* Restart containers: `docker-compose restart`
* Tear down the grid: `docker-compose down`
* Stop all running containers: `docker kill $(docker ps -q)`
* List all containers: `docker ps -a` or `docker container ls`
* Delete all containers: `docker rm -f $(docker ps -a -q)`
* List all images: `docker images`
* Delete an image: `docker rmi <image>` 

## Swarm
To setup a swarm:
1. Access to more than one machine.
2. Know their IPs and network successfully.
3. Initialize a swarm and make our PC a manager: `docker swarm init`
4. Add a worker to the swarm by running on the other machine the command provided by swarm init: `docker swarm join --token <tokenProvided> 192.168.2.14:2377` ()
5. To add a manager to the swarm: `docker swarm join-token manager` and follow the instructions.
6. Now you have all the nodes connected (`docker node ls`), deploy the swarm by running `docker stack deploy`
7. Run your tests against Selenium Grid.



## The grid
* See it running: `http://localhost:4444/grid/console`

[!](img/gridRunning.png)

## NUnit and Selenium
```
dotnet new unit
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package WebDriverManager
dotnet test
```

## Run
```
docker-compose up -d --scale chrome=1
dotnet test
docker-compose down
```

## References
* https://github.com/ElSnoMan/esports-automation
* https://testautomationu.applitools.com/scaling-tests-with-docker
