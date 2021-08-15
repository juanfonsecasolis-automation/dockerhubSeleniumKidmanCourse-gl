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

## Commands
```
* Setup containers defined on the docker-compose.yml: `docker-compose up -d`
* Restart containers: `docker-compose restart`
* Tear down the grid: `docker-compose down`
* Stop all running containers: `docker kill $(docker ps -q)`
* List all containers: `docker ps -a`
* Delete all containers: `docker rm -f $(docker ps -a -q)`
* List all images: `docker images`
* Delete an image: `docker rmi <image>` 

## The grid
* See it running: `http://localhost:4444/grid/console`

[!](img/gridRunning.png)
