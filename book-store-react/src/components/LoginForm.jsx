import {Link} from 'react-router-dom'

const LoginForm = () => {
  return (
    <section className="login">
      <div className="container">
        <h2 className="text-medium text-center mt-2">ΣΥΝΔΕΣΗ</h2>
        <p className="text-center">Παρακαλούμε συνδεθείτε στον λογαριασμό σας για να συνεχίσετε τις αγορές σας και να απολαύσετε όλες τις αποκλειστικές υπηρεσίες μας.</p>
        <p className="text-center">Εάν δεν έχετε λογαριασμό, <Link to="/register">εγγραφείτε εδώ</Link> για να γίνετε μέλος της κοινότητας του BookStore.</p>
        <div className="form">
          <form action="#">
              <div className="form-group">
                <label htmlFor="email"><span className="required">*</span>E-MAIL</label>
                <input type="email" name="email" id="email" />
              </div>
    
              <div className="form-group">
                <label htmlFor="password">Password<span className="required">*</span></label>
                <input type="password" name="password" id="password" />
              </div>

            <div className="form-group flex">
              <input type="submit" className="btn" value="Σύνδεση" />
            </div>
          </form>
        </div>  
      </div>
    </section>
  )
}

export default LoginForm