# AKS demo

This is a demo to show deployment in AKS.

I was getting some issues related to Azure login from GitHub action, for that I manually deployed the containers
to AKS.

Steps:

- Create a new AKS resource in Azure
- Login to Azure PowerShell from your local computer or use CloudShell
- Install `kubectl` in your local machine if not already. If you are using CloudShell then `kubectl` is already
installed
- Import AKS credentials

```
Import-AzAksCredential -ResourceGroupName <resource group name> -Name <aks name>
```

- Deploy to AKS

```
kubectl apply -f aks-deploy.yml
```

- Check the nodes and pods

```
kubectl get nodes

kubectl get pods
```

- Get the external ips of the services

```
kubectl get service api1

kubectl get service api2
```

- Open web browser and navigate to the url

```
http://<api 1 external ip>/HelloApi?name=Jon

http://<api 2 external ip>/HelloApi?name=Jon
```

- You should be able to see the output