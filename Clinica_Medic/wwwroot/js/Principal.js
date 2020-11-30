
class Principal {
    userLink(URLactual) {
        var provider = new Provider();
        var shopping = new Shopping();
        let url = "";
        let cadena = URLactual.split("/");
        for (var i = 0; i < cadena.length; i++) {
            if (cadena[i] != "Index") {
                url += cadena[i];
            }
        }
        switch (url) {
            case "UsersRegister":
                document.getElementById('files').addEventListener('change', imageUser, false);
                break;
            case "CustomersRegister":
                document.getElementById('files').addEventListener('change', imageCustomer, false);
                break;
            case "CustomersReports":
                document.getElementById('inlineRadio1').checked = true;
                document.getElementById('inlineRadio2').checked = false;
                document.getElementById('inlineRadio1').disabled = false;
                document.getElementById('inlineRadio2').disabled = true;
                new Customers().SetSection(1);
                break;
            case "ProviderRegister":
                document.getElementById('files').addEventListener('change', imageProvider, false);
                break;
            case "ProviderReports":
                provider.SetSection(1);
                $('#PaymentProvider').keyup((e) => {
                    var key = e.which || e.keyCode || e.charCode;
                    if (key == 8) {
                        provider.Payments(e, null);
                    }
                    return true;
                });
                provider.Check();
                break;
            case "ShoppingAddShopping":
                $("#Input_Quantity").change((e) => {
                    shopping.purchaseAmount();
                });
                document.getElementById('files').addEventListener('change', imageShopping, false);
                shopping.Restore();
                break;
        }
    }
}
