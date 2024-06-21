import React from 'react'
import homeImage from '../assets/images/homeImage.png' 

const Hero = (props) => {
  return (
    <>
    <section className="hero">
      <div className="container">
        <p className="text-large text-light text-center">{ props.title }</p>
      </div>
      </section>
        <section className="image">
        <div>
          <img src={homeImage} alt=""/>
        </div>
      </section>
    </>
  )
}

export default Hero