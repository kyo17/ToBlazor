function deleteJs(text, msg, action) {
    return new Promise((resolve) => {
        Swal.fire({
            title: text,
            text: msg,
            type: action,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#000000',
            confirmButtonText: 'Si, Eliminar el archivo'
        }).then((result) => {
            if (result.value) {
                resolve(true);
            } else {
                resolve(false);
            }
        });
    });
}