import { Link } from 'react-router-dom'
import { RiDeleteBinLine } from "react-icons/ri";

const CheckoutTable = () => {
  return (
    <section className="basket">
      <div className="container">
        <h2 className="text-center text-medium"><span className="text-highlight">Καλάθι Αγορών</span></h2>
        <table>
          <tr>
            <th>Εικόνα</th>
            <th>Όνομα Προϊόντος</th>
            <th>Ποσότητα</th>
            <th>Τιμή μονάδας</th>
            <th>Σύνολο</th>
            <th>Αφαίρεση</th>
          </tr>
          <tr>
            <td><img src="images/sapiens.png" alt="" /></td>
            <td>Sapiens - Μια σύντομη ιστορία του ανθρώπου</td>
            <td>1</td>
            <td>132,00€</td>
            <td>132,00€</td>
            <td><Link to="#"><RiDeleteBinLine className="required"/></Link></td>
          </tr>
        </table>
        <div className="flex">
          <p><span className="text-strong">Κόστος Παραγγελίας:</span> <span id="total-cost-value">100.25</span>&euro;</p>
        </div>
      </div>
    </section>
  )
}

export default CheckoutTable