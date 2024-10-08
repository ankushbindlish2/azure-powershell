if(($null -eq $TestName) -or ($TestName -contains 'New-AzWebPubSubHub'))
{
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath))
    {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'New-AzWebPubSubHub.Recording.json'
    $currentPath = $PSScriptRoot
    while(-not $mockingPath)
    {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'New-AzWebPubSubHub' {
    It 'CreateExpanded' {
        $eventHandlers = @{UrlTemplate = 'http://example.com/api/{hub}/connect/{event}' ; AuthType = 'None' ; SystemEvent = 'connect' ; } ,
        @{ UrlTemplate = 'http://example.com/api/{hub}/userevent/{event}' ; AuthType = 'None' ; UserEventPattern = '*' }

        $eventListeners =
        @{
            Endpoint = $(New-AzWebPubSubEventHubEndpointObject -EventHubName connectivityHub -FullyQualifiedNamespace example.servicebus.windows.net);
            Filter = $(New-AzWebPubSubEventNameFilterObject -SystemEvent connected, disconnected)
        },
        @{
            Endpoint = $(New-AzWebPubSubEventHubEndpointObject -EventHubName messageHub -FullyQualifiedNamespace example.servicebus.windows.net);
            Filter = $(New-AzWebPubSubEventNameFilterObject -UserEventPattern *)
        }

        $hubName = 'testHub'
        $hub = New-AzWebPubSubHub -Name $hubName -ResourceGroupName $env.ResourceGroupName -ResourceName $env.Wps1 -EventHandler $eventHandlers -EventListener $eventListeners

        $hub.Name | Should -Be $hubName
        $hub.EventHandler | Should -HaveCount 2
        $hub.EventListener | Should -HaveCount 2
    }
}
