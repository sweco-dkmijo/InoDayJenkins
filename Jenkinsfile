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
                echo "Building InoDayJenkins"
                bat "dotnet build \"InoDayJenkins.sln\" /p:DeployOnBuild=true /p:PublishProfile=FolderProfile1 /p:PublishProfileRootFolder=\"%WORKSPACE%\\Properties\\PublishProfiles\""
            }
        }
		
		stage('Copy Build to Another Folder') {
            steps {
                script {
                    def branchName = env.GIT_BRANCH.replaceAll('/', '_') // Replaces '/' in branch name with '_' to create a valid directory name
                    def targetDirectory = "E:\\Build\\${branchName}"

                    echo "Removing previous build folder"
                    bat "if exist ${targetDirectory} rd /s /q ${targetDirectory}" // Remove the target directory if it exists
            
                    echo "Copying build to another folder"
                    bat "if not exist ${targetDirectory} mkdir ${targetDirectory}" // Create the target directory if it doesn't exist
                    bat "Xcopy \"%WORKSPACE%\\publish\" ${targetDirectory} /E /H /C /I"
            
                    // Update the target directory for the 'Move Files to Staging Server' stage
                    env.TARGET_DIRECTORY = targetDirectory
                }
            }
        }

        stage('Copy Build to Specific Directory for Develop Branch') {
			steps {
				script {
					def targetDirectory = "E:\\INetPub\\JekninsInnoDay\\RAGS"
					echo "Copying files to specific directory for mock IIS"
					bat "Xcopy \"%WORKSPACE%\\publish\" ${targetDirectory} /E /H /C /I"
				}
				
            }
        }        

    }
}
