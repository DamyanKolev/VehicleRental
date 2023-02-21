



//Hide SingIn/SignOut dialog window event listener
function HideDialogWindow() {
    const hideBtn = document.getElementById("login-dialog--hide-button")
    const showBtn = document.getElementById("shellbar--acount");
    const dialog = document.getElementById('login-dialog');

    //hide event listener
    hideBtn.addEventListener("click", () => {
        dialog.classList = "fd-dialog-docs-static fd-dialog";
    })

    showBtn.addEventListener("click", () => {
        dialog.classList = "fd-dialog-docs-static fd-dialog fd-dialog--active";
    })
}


HideShowDialogWindow();