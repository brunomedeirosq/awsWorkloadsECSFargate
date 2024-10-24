# Command description
## Docker login AWS CLI
To authenticate Docker with an Amazon ECR registry using the AWS CLI, use the get-login-password command and pipe the output to docker login, specifying AWS as the username and the URL to the registry.
### Command line example
`aws ecr get-login-password --region region | docker login --username AWS --password-stdin aws_account_id.dkr.ecr.region.amazonaws.com`
## Docker login AWS Tools for PowerShell
`(Get-ECRLoginCommand -Region region).Password | docker login --username AWS --password-stdin aws_account_id.dkr.ecr.region.amazonaws.com`

# Hands-on

Developed a .NET Web API project that retrieves weather data from a database table. Part of this task involved using the AWS Management Console to create a DynamoDB table and populate it with weather data. Deployed the WeatherAPI project to Amazon ECS on Fargate, using the AWS deployment tool for .NET CLI.

Developed a website that retrieves data from the WeatherAPI. Deployed the WeatherSite project to Amazon ECS on Fargate, using the .NET CLI. 

Updated the weather data and the website, and deployed the updated website to Amazon ECS. After testing the projects, you deleted the deployments for WeatherSite and WeatherAPI, and deleted the Weather DynamoDB table by using the AWS Management Console.

## Endpoint

http://Weathe-Recip-Vd2cFWiFsYe0-333349296.eu-north-1.elb.amazonaws.com/

http://weathe-recip-vd2cfwifsye0-333349296.eu-north-1.elb.amazonaws.com/WeatherForecast?location=Dallas

********************
AWS Resource Details
********************

Application Endpoint:
        Id: arn:aws:elasticloadbalancing:eu-north-1:730335604912:loadbalancer/app/Weathe-Recip-Vd2cFWiFsYe0/d382d3efbdaf5f05
        Type: AWS::ElasticLoadBalancingV2::LoadBalancer
        Endpoint: http://Weathe-Recip-Vd2cFWiFsYe0-333349296.eu-north-1.elb.amazonaws.com/
ECS Service:
        Id: arn:aws:ecs:eu-north-1:730335604912:service/WeatherAPI/WeatherAPI-service
        Type: AWS::ECS::Service
ECS Cluster:
        Id: WeatherAPI
        Type: AWS::ECS::Cluster

********************
AWS Resource Details
********************

Application Endpoint:
        Id: arn:aws:elasticloadbalancing:eu-north-1:730335604912:loadbalancer/app/Weathe-Recip-gDJJL20KLmg4/d626b4f2d51dcfe2
        Type: AWS::ElasticLoadBalancingV2::LoadBalancer
        Endpoint: http://Weathe-Recip-gDJJL20KLmg4-1879535924.eu-north-1.elb.amazonaws.com/
ECS Service:
        Id: arn:aws:ecs:eu-north-1:730335604912:service/WeatherSite/WeatherSite-service
        Type: AWS::ECS::Service
ECS Cluster:
        Id: WeatherSite
        Type: AWS::ECS::Cluster