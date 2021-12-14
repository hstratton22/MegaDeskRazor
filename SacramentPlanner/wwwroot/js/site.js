
    function PrintDiv() {
                var divToPrint = document.getElementById('printArea');
    var popupWin = window.open('', '_blank', 'width=500,height=700,location=no,left=200px');
    popupWin.document.open();
    popupWin.document.write('<html><body onload="window.print()">' + divToPrint.innerHTML + '</html>');
        popupWin.document.close();
            }
      