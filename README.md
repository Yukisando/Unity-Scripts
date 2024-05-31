<details><summary>How to add files?</summary>

[Create](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#create-a-file) or [upload](https://docs.gitlab.com/ee/user/project/repository/web_editor.html#upload-a-file) files

[Add files using the command line](https://docs.gitlab.com/ee/gitlab-basics/add-file.html#add-a-file-using-the-command-line) or push an existing Git repository with the following command:

```
cd existing_repo
git remote add origin https://gitlab.valbilon.ch/valbilon/tools/useful-scripts-unity.git
git branch -M main
git push -uf origin main
```
</details> 

# Script descriptions:

## AlphaButtonMask
 - Ignores ray cast on transparent pixels
## FakeBoarder
 - Simulates keyboard inputs
## GitCommandsMenu
 - Adds a menu item to git commit/push/revert
## KeystorePasswordSetter
 - Auto fill android keystore key on load
## PlatformBuilder
 - Adds a menu item to build in various platform with smart level naming
 - Supports packing builds into a single ".exe" file using the "self-extracting archive" but requires the user to have winrar installed and added to their system variables
