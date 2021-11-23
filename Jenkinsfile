/* see https://www.jenkins.io/doc/book/pipeline/ */

pipeline {
	agent any
	
 
	stages {
		stage("clean workspace"){
			steps{
				cleanWs()
			}
		}
		stage("git pull") {
			steps {					
				bat "git clone C:/Users/rothexD/Documents/GitHub/isAHelloWorld2 ."
			}
		}
		stage("build") {
			steps {
				bat "dotnet build ./Is2Plus2Equal2"			
			}
		}	
		stage("Test") {
			steps {
				bat "dotnet test --settings test.runsettings ./Is2Plus2Equal2"			
			}	
		}
		stage('Build Docker Image'){
			steps{
				bat "docker build -t rothexd/isahelloworld2 ."
			}
		}
		stage('Publish Docker Image'){
			steps{
				withCredentials([string(credentialsId: 'docker-pwd', variable: 'dockerHubPw')]){
					bat "docker login -u rothexd -p ${dockerHubPw}"
					bat "docker push rothexd/isahelloworld2"	
				}	
			}
		}
		
	}
	
	post {
		always {
			dir("./UnitTestsGoHere/bin/Debug/netcoreapp5.0/testresults"){
				nunit testResultsPattern: "*.xml", failedTestsFailBuild : true				
			}	
		}
	}
}
