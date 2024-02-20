pipeline {
    agent any
    
    stages {
        stage('Copy NuGet Exe and Config') {
            steps {
                echo "Copying new NuGet exe and config"
                bat "COPY C:\\ProgramData\\Jenkins\\nuget.exe \"%WORKSPACE%\\.nuget\" /Y"
                bat "COPY C:\\ProgramData\\Jenkins\\NuGet.targets \"%WORKSPACE%\\.nuget\" /Y"
            }
        }
        
        stage('Restore NuGet Packages') {
            steps {
                echo "Restoring NuGet packages"
                bat "\"%WORKSPACE%\\.nuget\\NuGet.exe\" restore \"InoDayJenkins.sln\""
            }
        }
        
        stage('Build InoDayJenkins') {
            steps {
                echo "Building RenoWeb Office"
                bat "\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\MSBuild\\Current\\Bin\\msbuild.exe\" \"InoDayJenkins.sln\" /p:DeployOnBuild=true /p:PublishProfile=FolderProfile /p:PublishProfileRootFolder=\"%WORKSPACE%\\Properties\\PublishProfiles\""
            }
        }
        

    }
}
