import {Link} from 'react-router-dom'

const CategoryList = ({category}) => {
  return (
    <div className="grid-item">
      <div className="box flex-column">
        <Link to={`/categories/${category.id}`}>
          <img src={category.image} className="box-image" alt=""/>
          <p className="title">{category.title}</p>
        </Link>
      </div>
    </div>
  )
}

export default CategoryList