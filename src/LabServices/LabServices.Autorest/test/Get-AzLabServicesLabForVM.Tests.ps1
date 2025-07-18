if(($null -eq $TestName) -or ($TestName -contains 'Get-AzLabServicesLabForVM'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzLabServicesLabForVM.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

$loadVarsPath = Join-Path $PSScriptRoot '\SetVariables.ps1'
. ($loadVarsPath)

Describe 'Get-AzLabServicesLabForVM' {
    It 'Get Lab from VM' {
        $vm = Get-AzLabServicesVM -LabName $env.LabName -ResourceGroupName $env.ResourceGroupName -Name 0
        Get-AzLabServicesLabForVM -ResourceId $vm.Id | Should -Not -BeNullOrEmpty
    }
}
