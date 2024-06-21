import {Link} from 'react-router-dom'

const RagisterFrom = () => {
  return (
    <section className="register">
      <div className="container">
        <h2 className="text-medium text-center mt-2">Δημιουργήστε τον Λογαριασμό σας στο BookStore</h2>
        <p className="text-center">
          Καλώς ήρθατε στο BookStore! Συμπληρώστε τα παρακάτω πεδία για να δημιουργήσετε τον λογαριασμό σας και να αποκτήσετε πρόσβαση σε μια πληθώρα μοναδικών 
          υπηρεσιών και προνομίων.<br/>
          Ήδη έχετε λογαριασμό; <Link to="/login">Συνδεθείτε εδώ</Link>.<br/>
          Ανυπομονούμε να σας καλωσορίσουμε στην κοινότητά μας!
        </p>
        <div className="form">
          <form action="#">
            <div className="grid">
              <div className="htmlForm-group">
                <label htmlFor="first-name">Όνομα<span className="required">*</span></label>
                <input type="first-name" name="first-name" id="first-name" />
              </div>
    
              <div className="htmlForm-group">
                <label htmlFor="last-name">Επώνυμο<span className="required">*</span></label>
                <input type="last-name" name="last-name" id="last-name" />
              </div>

              <div className="htmlForm-group">
                <label htmlFor="email"><span className="required">*</span>E-mail</label>
                <input type="email" name="email" id="email" />
              </div>

              <div className="htmlForm-group">
                <label htmlFor="phone">Τηλέφωνο<span className="required">*</span></label>
                <input type="phone" name="phone" id="phone" />
              </div>

              <div className="htmlForm-group">
                <label htmlFor="city">Πόλη<span className="required">*</span></label>
                <input type="city" name="city" id="city" />
              </div>

              <div className="htmlForm-group">
                <label htmlFor="address">Διεύθυνση<span className="required">*</span></label>
                <input type="address" name="address" id="address" />
              </div>

              <div className="htmlForm-group">
                <label htmlFor="zip-code">T.K<span className="required">*</span></label>
                <input type="zip-code" name="zip-code" id="zip-code" />
              </div>
            </div>
  
            <div className="htmlForm-group flex">
              <input type="submit" className="btn" value="Δημιουργία" />
            </div>
          </form>
        </div>  
      </div>
    </section>
  )
}

export default RagisterFrom