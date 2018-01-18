
run:
	dotnet run

dockerize:
	dotnet publish -o out
	docker build -t dotnetapp .

dockerrun:
	echo "-- running on external port 6005 --"
	docker run -p 6005:3000 dotnetapp