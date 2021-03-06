package vrecservice;


public class MessageResponse extends AbstractResponse
{
	private String message;
	
	public MessageResponse(String message)
	{
		this.setMessage(message);
		this.setStatus(true);
	}

	/**
	 * @return the message
	 */
	public String getMessage() {
		return message;
	}

	/**
	 * @param message the message to set
	 */
	public void setMessage(String message) {
		this.message = message;
	}

	@Override
	public String JSONSerialize() 
	{
		return serializer.serialize(this);
	}
}
