# you might need to run this as a super user (sudo)
docker-compose up -d --scale chrome=1
dotnet test
docker-compose down
