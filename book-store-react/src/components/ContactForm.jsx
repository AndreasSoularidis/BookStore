

const ContactForm = () => {
  return (
    <section className="contact">
      <div className="container">
        <h2 className="text-medium text-center mt-2">ΕΠΙΚΟΙΝΩΝΙΑ</h2>
        <p className="text-center">ΕΧΕΤΕ ΕΡΩΤΗΣΕΙΣ Ή ΧΡΕΙΑΖΕΤΕ ΒΟΗΘΕΙΑ; ΣΥΜΠΛΗΡΩΣΤΕ ΤΗΝ ΦΟΡΜΑ ΕΠΙΚΟΙΝΩΝΙΑΣ ΚΑΙ ΘΑ ΣΑΣ ΒΟΗΘΗΣΟΥΜΕ ΜΕ ΧΑΡΑ.</p>
        <div className="form">
          <form action="#">
              <div className="form-group">
                <label htmlFor="first-name">Όνομα<span className="required">*</span></label>
                <input type="first-name" name="first-name" id="first-name" />
              </div>
    
              <div className="form-group">
                <label htmlFor="last-name">Επώνυμο<span className="required">*</span></label>
                <input type="last-name" name="last-name" id="last-name" />
              </div>

              <div className="form-group">
                <label htmlFor="email"><span className="required">*</span>E-MAIL</label>
                <input type="email" name="email" id="email" />
              </div>
    
              <div className="form-group">
                <label htmlFor="phone">Τηλέφωνο<span className="required">*</span></label>
                <input type="phone" name="phone" id="phone" />
              </div>

            <div className="form-group">
              <label htmlFor="msg">Μήνυμα<span className="required">*</span></label>
              <textarea name="msg" id="msg" cols="30" rows="10"></textarea>
            </div>

            <div className="form-group flex">
              <input type="submit" className="btn" value="Αποστολή" />
            </div>
          </form>
        </div>  
      </div>
    </section>
  )
}

export default ContactForm