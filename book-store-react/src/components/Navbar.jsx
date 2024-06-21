import { Link } from 'react-router-dom';
import { FaCartPlus } from "react-icons/fa6";
import { FaUser } from "react-icons/fa";

const Navbar = () => {
  return (
    <header className="main-nav">
      <div className="container flex flex-right secondary-menu">
        <nav>
          <ul className="flex ">
            <li className="mr-1"><Link to="/login"><FaUser className='mr-0'/>Σύνδεση/Εγγραφή</Link></li>
            <li className=" mr-1"><Link to="/checkout"><FaCartPlus className='mr-0'/>Καλάθι</Link></li>
          </ul>
        </nav>
      </div>
      <div className="container main-menu flex space-around">
        <div className="logo"><a href="/">Book<span className="highlight">Store</span></a></div>
        <nav>
          <ul className="flex">
            <li className="ml-2"><Link to="/" className="selected">Αρχική</Link></li>
            <li className="ml-2"><Link to="/categories">Κατηγορίες</Link></li>
            <li className="ml-2"><Link to="/about">Σχετικά</Link></li>
            <li className="ml-2"><Link to="/contact">Επικοινωνία</Link></li>
          </ul>
        </nav>
      </div>
    </header>
  )
}

export default Navbar