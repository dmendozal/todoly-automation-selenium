# todoly-automation-selenium

# STEPS to configure selenium grid

# Step 1
Download the yaml configuration for selenium grid from https://github.com/SeleniumHQ/docker-selenium.
The filename is "docker-compose-v3.yml"

# Step 2
Create a file in the root of the test project with the name of docker-compose.yaml and copy the content 
from "docker-compose-v3.yml" to "docker-compose.yaml".

# Step 3
Configure your docker in your local with next commands:
- cd {fullpathproject}
- docker-compose up -d (to run images)
- docker-compose ps (to show activated images)
- open "http://localhos:4444" and click on "sessions"
