# 获取脚本所在的目录
$scriptDir = $PSScriptRoot

# 查找所有 .rsp 文件
$rspFiles = Get-ChildItem -Path $scriptDir -Filter *.rsp

$toolName = "ClangSharpPInvokeGenerator"

# 遍历并执行每个 .rsp 文件
foreach ($file in $rspFiles) {
    Write-Host "start processing: $($file.Name)..."
    
    # 切换到脚本目录以确保相对路径正确解析
    Push-Location $scriptDir
    
    try {
        # 执行 ClangSharpPInvokeGenerator，并传入 .rsp 文件作为参数
        & $toolName "@$($file.Name)"
        
        if ($LASTEXITCODE -ne 0) {
            Write-Error "processing $($file.Name) error. code: $LASTEXITCODE"
        } else {
            Write-Host "processing: $($file.Name) finish"
        }
    }
    catch {
        Write-Error "processing $($file.Name) error: $_"
    }
    finally {
        # 返回原始目录
        Pop-Location
    }
}

Write-Host "done!"