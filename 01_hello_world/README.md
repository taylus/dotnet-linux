# Installing .NET Core on Ubuntu 18.04
https://www.microsoft.com/net/download/linux-package-manager/ubuntu18-04/sdk-current

## If you get the error "Unable to correct problems, you have held broken packages" when installing dotnet-sdk-2.1
The package relies on `libicu55` which isn't included in Ubuntu's default repositories. Install it via:
```bash
wget http://security.ubuntu.com/ubuntu/pool/main/i/icu/libicu55_55.1-7ubuntu0.4_amd64.deb
sudo apt install ./libicu55_55.1-7ubuntu0.4_amd64.deb
```
Source: https://askubuntu.com/questions/905018/install-powershell-in-ubuntu-17-04/939367#939367

# Compiling and running an application
https://www.microsoft.com/net/learn/get-started/linux/ubuntu18-04#create