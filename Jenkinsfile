pipeline {
    agent any
    
    stages {
        
        stage('Restore NuGet Packages') {
            steps {
                echo "Restoring NuGet packages"
                bat "dotnet restore \"InoDayJenkins.sln\""
            }
        }
        
        stage('Build InoDayJenkins') {
            steps {
                echo "Building RenoWeb Office"
                bat "dotnet build \"InoDayJenkins.sln\" /p:DeployOnBuild=true /p:PublishProfile=FolderProfile /p:PublishProfileRootFolder=\"%WORKSPACE%\\Properties\\PublishProfiles\""
            }
        }
        

    }
}
